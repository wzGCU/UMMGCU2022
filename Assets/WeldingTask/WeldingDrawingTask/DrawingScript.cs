using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    public Sprite basic, clicked;

    public LineRenderer LineRenderer;
    public float lineWidth = 0.06f;
    public float minimumDist = 0.01f;
   
    private bool isLineStarted;

    public GearCounter gearCounter;


    public Player player;

    private int points;
   /* private Vector3 point1 = new Vector3(-0.2f, 1.3f, -9f);
    private Vector3 point2 = new Vector3(-0.2f, 1.2f, -9f);
    private Vector3 point3 = new Vector3(-0.1f, 1.1f, -9f);
    private Vector3 point4 = new Vector3(0.05f, 1.1f, -9f);*/
 

    void Start()
    {
        // setting gthe color to be gradienty
        LineRenderer.startColor = Color.grey; 
        LineRenderer.endColor = Color.red;

        // set width of the renderer
        LineRenderer.startWidth = lineWidth;
        LineRenderer.endWidth = lineWidth;

        //resetting the linerenderer
        isLineStarted = false;
        LineRenderer.positionCount = 0;
        gearCounter = FindObjectOfType<GearCounter>();
        player = FindObjectOfType<Player>();
      
    }

    void Update()
    {
        transform.position = GetWorldCoordinate(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            //setting new sprite if its not the proper one
            if(transform.GetComponent<SpriteRenderer>().sprite == basic)
            {
                transform.GetComponent<SpriteRenderer>().sprite = clicked;
            }
            LineRenderer.positionCount = 0;
            Vector3 mousePos = GetWorldCoordinate(Input.mousePosition);

            LineRenderer.positionCount = 2;
            LineRenderer.SetPosition(0, mousePos);
            LineRenderer.SetPosition(1, mousePos);
            isLineStarted = true;
        }

        if (Input.GetMouseButton(0) && isLineStarted)
        {
            Vector3 currentPos = GetWorldCoordinate(Input.mousePosition);
            float distance = Vector3.Distance(currentPos, LineRenderer.GetPosition(LineRenderer.positionCount - 1));
            if (distance > minimumDist)
            {
                UpdateLine();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            //resetting back to normal sprite
            if (transform.GetComponent<SpriteRenderer>().sprite == clicked)
            {
                transform.GetComponent<SpriteRenderer>().sprite = basic;
            }

            
            if (LineRenderer.positionCount >= 120)
            {
                Debug.Log("TaskFinished");
                gearCounter.gearsWelded = true;
                gearCounter.playerCamera.SetActive(true);
                player.questStep = 8;
                transform.parent.gameObject.SetActive(false);

            }
            isLineStarted = false;
        }
    }

    private void UpdateLine()
    {
        LineRenderer.positionCount++;
        LineRenderer.SetPosition(LineRenderer.positionCount - 1, GetWorldCoordinate(Input.mousePosition));
    }

    private Vector3 GetWorldCoordinate(Vector3 mousePosition)
    {
        Vector3 mousePos = new Vector3(mousePosition.x, mousePosition.y, 1);
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
