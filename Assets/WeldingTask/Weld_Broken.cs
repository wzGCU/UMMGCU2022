using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weld_Broken : MonoBehaviour
{
    bool clickable = true;
    public Sprite sprite, highlightSprite;
    void OnMouseDrag()
    {
        if (clickable)
        {
            //getting the raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 newpos = new Vector3();
            if (Physics.Raycast(ray, out RaycastHit raycastHit))
            {

                newpos = new Vector3(raycastHit.point.x, raycastHit.point.y, transform.position.z);

            }
            Collider2D[] colliders = Physics2D.OverlapCircleAll(newpos, .0001f);
            foreach (Collider2D collider in colliders)
            {
                //make sure not own collider
                if (collider.gameObject != gameObject && collider.gameObject.transform.parent.gameObject.name == "slots")
                {
                    transform.position = collider.transform.position;
                    collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    WeldTorch.Instance.PuzzleAddPoint();
                    clickable=false;
                    return;
                }
            }
            transform.position = newpos;
        }
        
    }
    void OnMouseOver()
    {
        if (clickable)
        {
            transform.GetComponent<SpriteRenderer>().sprite = highlightSprite;
        }
  
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
