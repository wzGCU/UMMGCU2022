using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{
    public GameObject title;
    private bool _playerInArea;

    void Start()
    {
        _playerInArea = false;
        title.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            title.SetActive(true);
            _playerInArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            title.SetActive(false);
            _playerInArea = false;
        }
    }
}
