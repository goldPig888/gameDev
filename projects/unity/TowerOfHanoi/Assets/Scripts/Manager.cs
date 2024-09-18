using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject[] poles;
    [SerializeField] private GameObject disk1, disk2, disk3, disk4, disk5;
    [SerializeField] private Text moveText;
    [SerializeField] private GameObject winMsg;

    private int selectedPole = -1;
    private int moveCount = 0;
    private List<GameObject>[] poleDisks = new List<GameObject>[3];
    private float[] diskYPos = { -3.75f, -3.25f, -2.5f, -2f, -1.25f };
    private bool isGameWon = false;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            poleDisks[i] = new List<GameObject>();
        }

        poleDisks[0].AddRange(new GameObject[] { disk1, disk2, disk3, disk4, disk5 });

        SetDiskPositions();
        winMsg.SetActive(false);
        moveText.text = "Moves: " + moveCount;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }
    }

    public void OnPoleClick(int poleIndex)
    {
        if (isGameWon) return;

        if (selectedPole == -1)
        {
            if (poleDisks[poleIndex].Count > 0)
            {
                selectedPole = poleIndex;
                FlipPole(poles[poleIndex], true);
            }
        }
        else
        {
            MoveDisk(selectedPole, poleIndex);
            FlipPole(poles[selectedPole], false);
            selectedPole = -1;
        }
    }

    private void MoveDisk(int fromPole, int toPole)
    {
        if (fromPole == toPole || poleDisks[fromPole].Count == 0)
        {
            return;
        }

        GameObject topDisk = poleDisks[fromPole][poleDisks[fromPole].Count - 1];
        float diskSize = topDisk.transform.localScale.x;

        if (poleDisks[toPole].Count == 0 || diskSize < poleDisks[toPole][poleDisks[toPole].Count - 1].transform.localScale.x)
        {
            poleDisks[fromPole].RemoveAt(poleDisks[fromPole].Count - 1);
            poleDisks[toPole].Add(topDisk);

            int posIndex = poleDisks[toPole].Count - 1;
            float newY = diskYPos[posIndex];
            float newX = poles[toPole].transform.position.x;

            topDisk.transform.position = new Vector3(newX, newY, topDisk.transform.position.z);

            moveCount++;
            moveText.text = "Moves: " + moveCount;

            CheckWin();
        }
    }

    private void CheckWin()
    {
        if (poleDisks[2].Count == 5)
        {
            winMsg.SetActive(true);
            moveText.text += "\nYou Win!";
            isGameWon = true;
        }
    }

    private void ResetGame()
    {
        winMsg.SetActive(false);
        moveCount = 0;
        moveText.text = "Moves: " + moveCount;
        isGameWon = false;

        for (int i = 0; i < 3; i++)
        {
            poleDisks[i].Clear();
        }

        poleDisks[0].AddRange(new GameObject[] { disk1, disk2, disk3, disk4, disk5 });

        SetDiskPositions();
    }

    private void SetDiskPositions()
    {
        float xPos = poles[0].transform.position.x;

        disk1.transform.position = new Vector3(xPos, diskYPos[0], -1f);
        disk2.transform.position = new Vector3(xPos, diskYPos[1], -1f);
        disk3.transform.position = new Vector3(xPos, diskYPos[2], -1f);
        disk4.transform.position = new Vector3(xPos, diskYPos[3], -1f);
        disk5.transform.position = new Vector3(xPos, diskYPos[4], -1f);
    }

    private void FlipPole(GameObject pole, bool flip)
    {
        SpriteRenderer sr = pole.GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            sr.flipY = flip;
        }
    }
}
