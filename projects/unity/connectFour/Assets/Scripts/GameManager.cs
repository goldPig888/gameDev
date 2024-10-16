using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject redPiecePrefab;
    public GameObject blackPiecePrefab;

    public GameObject gameBoard;

    public int rows = 6;
    public int columns = 7;
    public float dropHeight =60f;
    public float dropSpeed = 6f;

    public float startXOffset = 0.1f;
    public float heightShrinkFactor = 0.98f;
    public float startYBottomOffset = 0.1f;

    public Text winnerText;

    private Vector2 boardStartPosition;

    private float cellWidth;
    private float cellHeight;
    private float adjustedBoardWidth;
    private float adjustedBoardHeight;

    private int[,] board;
    private bool isRedTurn = true;
    private bool isPieceFalling = false;
    private bool gameOver = false;

    private GameObject hoveringPiece;

    void Start()
    {
        board = new int[rows, columns];
        CalculateBoardDimensions();

        redPiecePrefab.SetActive(false);
        blackPiecePrefab.SetActive(false);
        winnerText.gameObject.SetActive(false);

        CreateHoveringPiece();
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }

        if (!gameOver && !isPieceFalling)
        {
            UpdateHoveringPiece();
        }

        if (!gameOver && Input.GetMouseButtonDown(0) && !isPieceFalling)
        {
            int column = GetMouseColumn();
            int row = GetLowestAvailableRow(column);

            if (row >= 0)
            {
                StartCoroutine(SpawnAndDropPiece(column, row));
            }
        }
    }


    void CalculateBoardDimensions()
    {
        SpriteRenderer boardSpriteRenderer = gameBoard.GetComponent<SpriteRenderer>();

        boardStartPosition = boardSpriteRenderer.bounds.min;
        adjustedBoardWidth = boardSpriteRenderer.bounds.size.x * 0.98f;
        adjustedBoardHeight = boardSpriteRenderer.bounds.size.y * heightShrinkFactor;

        boardStartPosition.x += startXOffset;
        boardStartPosition.y += startYBottomOffset;

        cellWidth = adjustedBoardWidth / columns;
        cellHeight = adjustedBoardHeight / rows;
    }

    int GetMouseColumn()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float relativeX = mousePosition.x - boardStartPosition.x;

        int column = Mathf.FloorToInt(relativeX / cellWidth);
        column = Mathf.Clamp(column, 0, columns - 1);
        return column;
    }




    int GetLowestAvailableRow(int column)
    {
        for (int row = 0; row < rows; row++)
        {
            if (board[row, column] == 0)
            {
                return row;
            }
        }
        return -1;
    }


    IEnumerator SpawnAndDropPiece(int column, int row)
    {
        isPieceFalling = true;

        GameObject piecePrefab = isRedTurn ? redPiecePrefab : blackPiecePrefab;
        GameObject spawnedPiece = Instantiate(piecePrefab, new Vector3(GetColumnCenterX(column), dropHeight, 0), Quaternion.identity);
        spawnedPiece.SetActive(true);
        spawnedPiece.tag = "PieceClone";

        Vector3 targetPosition = new Vector3(GetColumnCenterX(column), GetRowCenterY(row), 0);

        while (spawnedPiece.transform.position.y > targetPosition.y)
        {
            spawnedPiece.transform.position = Vector3.MoveTowards(spawnedPiece.transform.position, targetPosition, dropSpeed * Time.deltaTime);
            yield return null;
        }

        StartCoroutine(JigglePiece(spawnedPiece));

        board[row, column] = isRedTurn ? 1 : 2;

        if (CheckWin(row, column, board[row, column]))
        {
            ShowWinner(isRedTurn ? "Red" : "Black");
            gameOver = true;
        }
        else if (IsBoardFull())
        {
            ShowWinner("TIE - PRESS 'R' TO RESET");
            gameOver = true;
        }

        isRedTurn = !isRedTurn;
        UpdateHoveringPieceSprite();
        isPieceFalling = false;
    }



    IEnumerator JigglePiece(GameObject piece)
    {
        Vector3 originalPosition = piece.transform.position;
        float jiggleAmount = .4f;
        float jiggleSpeed = 10f;
        float jiggleDuration = .6f;
        float elapsed = 0f;

        while (elapsed < jiggleDuration)
        {
            elapsed += Time.deltaTime;
            float jiggle = Mathf.Abs(Mathf.Sin(elapsed * jiggleSpeed) * jiggleAmount);
            piece.transform.position = originalPosition + new Vector3(0, jiggle, 0);
            yield return null;
        }

        piece.transform.position = originalPosition;
    }


    bool CheckWin(int row, int col, int player)
    {
        return (CheckDirection(row, col, 1, 0, player) + CheckDirection(row, col, -1, 0, player) >= 3) ||
               (CheckDirection(row, col, 0, 1, player) + CheckDirection(row, col, 0, -1, player) >= 3) ||
               (CheckDirection(row, col, 1, 1, player) + CheckDirection(row, col, -1, -1, player) >= 3) ||
               (CheckDirection(row, col, 1, -1, player) + CheckDirection(row, col, -1, 1, player) >= 3);
    }


    int CheckDirection(int row, int col, int rowDelta, int colDelta, int player)
    {
        int count = 0;

        for (int i = 1; i < 4; i++)
        {
            int newRow = row + rowDelta * i;
            int newCol = col + colDelta * i;

            if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= columns)
                break;

            if (board[newRow, newCol] == player)
                count++;
            else
                break;
        }

        return count;
    }


    bool IsBoardFull()
    {
        for (int col = 0; col < columns; col++)
        {
            if (board[rows - 1, col] == 0)
            {
                return false;
            }
        }
        return true;
    }


    void ShowWinner(string winner)
    {
        winnerText.gameObject.SetActive(true);
        winnerText.text = winner + " WINS!";
        if (winner == "TIE - PRESS 'R' TO RESET")
        {
            winnerText.text = "TIE - PRESS 'R' TO RESET";
        }
    }



    void ResetGame()
    {
        board = new int[rows, columns];
        isRedTurn = true;
        gameOver = false;
        winnerText.gameObject.SetActive(false);

        foreach (GameObject piece in GameObject.FindGameObjectsWithTag("PieceClone"))
        {
            Destroy(piece);
        }
    }



    float GetColumnCenterX(int column)
    {
        return boardStartPosition.x + (column * cellWidth) + (cellWidth / 2);
    }

    float GetRowCenterY(int row)
    {
        return boardStartPosition.y + (row * cellHeight) + (cellHeight / 2);
    }

    void CreateHoveringPiece()
    {
        GameObject piecePrefab = isRedTurn ? redPiecePrefab : blackPiecePrefab;
        hoveringPiece = Instantiate(piecePrefab);
        hoveringPiece.SetActive(true);
        hoveringPiece.tag = "HoveringPiece";
    }

    void UpdateHoveringPiece()
    {
        int column = GetMouseColumn();
        Vector3 hoveringPosition = new Vector3(GetColumnCenterX(column), dropHeight, 0);
        hoveringPiece.transform.position = hoveringPosition;
    }

    void UpdateHoveringPieceSprite()
    {
        Destroy(hoveringPiece);
        CreateHoveringPiece();
    }
}
