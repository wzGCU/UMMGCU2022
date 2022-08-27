using UnityEngine;

public class PipeMinigame : MonoBehaviour
{
    [SerializeField] private PipeTile[] pipeTileGrid = new PipeTile[25];      //Array of Pipe Tiles containing 25 entries (for a 5x5 grid)
    int timeLimitMax = 120;      //Time (in seconds) that the player has to complete the puzzle.
    float timerCountdown;
    bool gameCompleted;


    private void Start()
    {
        timerCountdown = timeLimitMax;
        gameCompleted = false;
    }


    void Update()
    {
        //Game timer
        if (timerCountdown > 0 && gameCompleted == false)
        {
            timerCountdown -= Time.deltaTime;
        }
        else if (timerCountdown <= 0)
        {
            print("You were too slow!");
            //END GAME (Fail)
        }

        //Win condition
        if ((pipeTileGrid[20].tileState == 1 || pipeTileGrid[20].tileState == 3) &&
            pipeTileGrid[21].tileState == 2 &&
            pipeTileGrid[16].tileState == 0 &&
            (pipeTileGrid[17].tileState == 1 || pipeTileGrid[17].tileState == 3) &&
            (pipeTileGrid[18].tileState == 1 || pipeTileGrid[18].tileState == 3) &&
            pipeTileGrid[19].tileState == 2 &&
            pipeTileGrid[14].tileState == 3 &&
            (pipeTileGrid[13].tileState == 1 || pipeTileGrid[13].tileState == 3) &&
            (pipeTileGrid[12].tileState == 1 || pipeTileGrid[17].tileState == 3) &&
            pipeTileGrid[11].tileState == 1 &&
            (pipeTileGrid[16].tileState == 0 || pipeTileGrid[16].tileState == 2) &&
            pipeTileGrid[1].tileState == 0 &&
            pipeTileGrid[2].tileState == 3 &&
            pipeTileGrid[7].tileState == 1 &&
            (pipeTileGrid[8].tileState == 1 || pipeTileGrid[8].tileState == 3) &&
            (pipeTileGrid[9].tileState == 1 || pipeTileGrid[9].tileState == 3) && 
            gameCompleted == false)
        {
            print("You did it!");
            gameCompleted = true;
            //END GAME (Win)
        }
    }
}