using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CogSlots : MonoBehaviour, IDropHandler
{
    public bool cog1 = false;
    public bool cog2 = false;
    public bool cog3 = false;
    public bool cog4 = false;
    public bool cog5 = false;

    public static bool cog1InPlace = false;
    public static bool cog2InPlace = false;
    public static bool cog3InPlace = false;
    public static bool cog4InPlace = false;
    public static bool cog5InPlace = false;

    public void OnDrop(PointerEventData eventData)
    {
        int placementSound = Random.Range(0, 6);

        if (placementSound <= 2)
        {
            FindObjectOfType<AudioManager>().Play("PlacingCog1");
        }

        if (placementSound >= 3)
        {
            FindObjectOfType<AudioManager>().Play("PlacingCog2");
        }

        if (cog1)
         {
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                cog1InPlace = true;
            }
         }

         if (cog2)
         {
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                cog2InPlace = true;
            }
         }

         if (cog3)
         {
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                cog3InPlace = true;
            }
         }

         if (cog4)
         {
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                cog4InPlace = true;
            }
         }

         if (cog5)
         {
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                cog5InPlace = true;
            }
         }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (this.tag == "Slot1")
        {
            if (other.tag == "Cog1")
            {
                cog1 = true;
            }
        }

        if (this.tag == "Slot2")
        {
            if (other.tag == "Cog2")
            {
                cog2 = true;
            }
        }

        if (this.tag == "Slot3")
        {
            if (other.tag == "Cog3")
            {
                cog3 = true;
            }
        }

        if (this.tag == "Slot4")
        {
            if (other.tag == "Cog4")
            {
                cog4 = true;
            }
        }

        if (this.tag == "Slot5")
        {
            if (other.tag == "Cog5")
            {
                cog5 = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (this.tag == "Slot1")
        {
            if (other.tag == "Cog1")
            {
                cog1 = false;
                cog1InPlace = false;
            }
        }

        if (this.tag == "Slot2")
        {
            if (other.tag == "Cog2")
            {
                cog2 = false;
                cog2InPlace = false;
            }
        }

        if (this.tag == "Slot3")
        {
            if (other.tag == "Cog3")
            {
                cog3 = false;
                cog3InPlace = false;
            }
        }

        if (this.tag == "Slot4")
        {
            if (other.tag == "Cog4")
            {
                cog4 = false;
                cog4InPlace = false;
            }
        }

        if (this.tag == "Slot5")
        {
            if (other.tag == "Cog5")
            {
                cog5 = false;
                cog5InPlace = false;
            }
        }
    }
}
