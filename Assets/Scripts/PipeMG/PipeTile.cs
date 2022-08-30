using UnityEngine;

public class PipeTile : MonoBehaviour
{
    public int tileState;   //Between 0 and 3, the rotation of the tile (rotation is 90 x tileState, if it goes > 3 it resets to 0).
    public AudioManager audioManager;


    void Start()
    {
        tileState = Random.Range(0, 4);     //Randomise each tile's starting tileState (pipe rotation)
        this.gameObject.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, tileState * 90);      //Set initial rotation of pipe to match tileState
    }


    public void RotateTile()       //Activated by Button component on Pipe Tile game object in Unity, triggers when player clicks on a tile.
    {
        tileState++;
        if (tileState > 3)
        {
            tileState = 0;
        }
        audioManager.Play("PipeTurn");
        this.gameObject.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, tileState * 90);        //Rotate pipe to match new tileState.
    }
}