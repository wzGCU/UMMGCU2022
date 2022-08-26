using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameWireController : MonoBehaviour
{
    
    public int puzzleTotalCount;
    //public GameObject win;
    private int puzzleCount = 0;

    static public MinigameWireController Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void PuzzleAddPoint()
    {
        puzzleCount++;
        if(puzzleCount == puzzleTotalCount)
        {
            Debug.Log("finished minigame");
            //win.SetActive(true);
        }
    }
}
