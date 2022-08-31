using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    public GameObject displayText;
    private bool _playerInArea;
    public Player player;
    public GameObject SleepFadeScreen;

    void Start()
    {
        _playerInArea = false;
        displayText.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }


    void Update()
    {
        if (_playerInArea && Input.GetKeyDown(KeyCode.F) && (player.questStep == 3 || player.questStep == 6 || player.questStep == 10))
        {
            switch (player.questStep)
            {
                case 3:
                    player.questStep = 4;
                    StartCoroutine("Sleep");
                    break;

                case 6:
                    player.questStep = 7;
                    StartCoroutine("Sleep");
                    break;

                case 10:
                    UnityEngine.SceneManagement.SceneManager.LoadScene("CreditsScreen");
                    break;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (player.questStep == 3 || player.questStep == 6 || player.questStep == 10)
        {
            if (other.gameObject.tag == "Player")
            {
                displayText.SetActive(true);
                _playerInArea = true;
            }
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

    IEnumerator Sleep()
    {
        SleepFadeScreen.SetActive(true);
        yield return new WaitForSeconds(1);
        SleepFadeScreen.SetActive(false);
    }
}