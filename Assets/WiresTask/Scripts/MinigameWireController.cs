using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameWireController : MonoBehaviour
{
    
    public int puzzleTotalCount;
    //public GameObject win;
    private int puzzleCount = 0;
    public GameObject wiresGame;
    public GameObject wiresText;
    public GameObject playerCamera;
    public Player player;
    public AudioManager mine;
    
    static public MinigameWireController Instance;
    private void Awake()
    {
        Instance = this;
        wiresText.SetActive(false);
    }
    public void PuzzleAddPoint()
    {
        int wiresSound = Random.Range(1, 6);

        if (wiresSound <= 3)
        {
            mine.Play("Zap1");
        }

        if (wiresSound >= 4)
        {
            mine.Play("Zap2");
        }

        puzzleCount++;
        if(puzzleCount == puzzleTotalCount)
        {
            wiresGame.SetActive(false);
            playerCamera.SetActive(true);
            Debug.Log("finished minigame");
            player.questStep = 2;
            //win.SetActive(true);
        }
    }
}
