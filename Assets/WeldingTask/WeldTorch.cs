using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldTorch : MonoBehaviour
{
    public int puzzleTotalCount;
    public GameObject win;
    private int puzzleCount = 0;
    public Sprite sprite, highlightSprite;
    

    static public WeldTorch Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void PuzzleAddPoint()
    {
        puzzleCount++;
    }

    private void OnMouseDown()
    {
        if (puzzleCount == puzzleTotalCount)
        {
            Debug.Log("finished minigame 1");
            Instantiate(win, transform.parent.transform.position, transform.parent.transform.rotation, transform.parent.transform.parent);
            Destroy(transform.parent.gameObject);
        }
        else
        {
            Debug.Log("not all pieces done. currently at: " + puzzleCount);
        }
    }
    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().sprite = highlightSprite;
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
