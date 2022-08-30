using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PipeCounter : MonoBehaviour
{
    private TMP_Text pipeText;
    public int pipeCount;
    public GameObject pipeMinigameStartPoint;


    void Start()
    {
        pipeText = GetComponent<TMP_Text>();
    }

    
    void Update()
    {
        pipeText.text = pipeCount.ToString();

        if (pipeCount == 1 && !pipeMinigameStartPoint.activeSelf)
        {
            pipeMinigameStartPoint.SetActive(true);
        }
    }
}
