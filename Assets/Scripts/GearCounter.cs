using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GearCounter : MonoBehaviour
{
    private TMP_Text gearText;
    public int gearCount = 0;
    void Start()
    {
        gearText = GetComponent<TMP_Text>();
    }
    void Update()
    {
        gearText.text = gearCount.ToString();
    }
}
