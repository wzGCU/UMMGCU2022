using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialInteractionEvent : MonoBehaviour
{
    public GameObject displayText;
    private bool _playerInArea;
    public GameObject action;
    public GameObject playerCamera;
    void Start()
    {
        _playerInArea = false;
        displayText.SetActive(false);
    }
    void Update()
    {
        if (_playerInArea && Input.GetKeyDown(KeyCode.F))
        {
            action.SetActive(true);
            playerCamera.SetActive(false);
        }    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            displayText.SetActive(true);
            _playerInArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            displayText.SetActive(false);
            _playerInArea = false;
        }
    }
}
