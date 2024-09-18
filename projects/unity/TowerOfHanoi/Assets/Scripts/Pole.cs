using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public Stack<GameObject> disks = new Stack<GameObject>();
    private Manager gameManager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        gameManager = FindObjectOfType<Manager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        gameManager.OnPoleClick(GetPoleIndex());
    }

    public void FlipPole()
    {
        spriteRenderer.flipY = !spriteRenderer.flipY;
    }

    private int GetPoleIndex()
    {
        if (gameObject.name == "pole1")
            return 0;
        if (gameObject.name == "pole2")
            return 1;
        if (gameObject.name == "pole3")
            return 2;

        return -1;
    }

    public void ResetPole()
    {
        disks.Clear();
        spriteRenderer.flipY = false;
    }
}
