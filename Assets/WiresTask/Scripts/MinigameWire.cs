using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameWire : MonoBehaviour
{
    public SpriteRenderer wireEnd; //used to longify the wire 
    Vector3 startPoint; //used for calculating the distance from the start of hovering wire
    Vector3 startPosition; //used for checking with the other wire
    
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void OnMouseDrag() 
    {
        //getting the raycast
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 newpos = new Vector3();
        if (Physics.Raycast(ray,out RaycastHit raycastHit, 100000f)){

            newpos = new Vector3(raycastHit.point.x, raycastHit.point.y, transform.position.z);
            
        }

        //check for snap point
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newpos, .2f);
        foreach (Collider2D collider in colliders)
        {
            //make sure not own collider
            if(collider.gameObject != gameObject)
            {
                UpdateWire(collider.transform.position);

                //check if wire is same colour
                if (transform.parent.name.Equals(collider.transform.parent.name))
                {
                    MinigameWireController.Instance.PuzzleAddPoint();
                    Destroy(this);
                }
                return;
            }
        }

        //update wire
        UpdateWire(newpos);
   
    }
    private void OnMouseUp()
    {
        //reset wire pos
        UpdateWire(startPosition);
        

    }

    private void UpdateWire(Vector3 newPosition)
    {
        transform.position = newPosition;
        //update dir
        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        //update scale
        float distance = Vector2.Distance(startPoint, newPosition);
        wireEnd.size = new Vector2(distance, wireEnd.size.y);
    }

}
