using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameWireController : MonoBehaviour
{
    
    public int puzzleTotalCount;
    //public GameObject win;
    private int puzzleCount = 0;
    public GameObject wiresGame;
    public GameObject playerCamera;
    
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
            wiresGame.SetActive(false);
            playerCamera.SetActive(true);
            Debug.Log("finished minigame");
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().questStep = 2;
            //win.SetActive(true);
        }
    }
}
