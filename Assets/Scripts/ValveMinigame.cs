using System.Collections;
using UnityEngine;

public class ValveMinigame : MonoBehaviour
{
    string possibleColours = "rbgy";        //Red, blue, green, yellow
    string round1Sequence;
    string round2Sequence;
    string round3Sequence;
    string round4Sequence;
    string playerInput;
    int currentRoundCounter;

    bool screenIsFlashing;
    public GameObject redLight;     //Game objects for the coloured lights that flash on the screen, set in-engine.
    public GameObject blueLight;
    public GameObject greenLight;
    public GameObject yellowLight;


    void Start()
    {
        //Generate sequences
        round1Sequence = possibleColours[Random.Range(0, 4)].ToString() + possibleColours[Random.Range(0, 4)].ToString() + possibleColours[Random.Range(0, 4)].ToString();      //Generate 3 random colours from the list
        round2Sequence = round1Sequence + possibleColours[Random.Range(0, 4)].ToString();   //The previous 3 colours, plus one more random one
        round3Sequence = round2Sequence + possibleColours[Random.Range(0, 4)].ToString();
        round4Sequence = round3Sequence + possibleColours[Random.Range(0, 4)].ToString();

        playerInput = "";
        currentRoundCounter = 1;

        StartCoroutine("FlashLights", round1Sequence);
    }


    IEnumerator FlashLights(string sequence)
    {
        screenIsFlashing = true;

        foreach (char colour in sequence)
        {
            if (colour.ToString() == "r")
            {
                redLight.SetActive(true);
            }
            else if (colour.ToString() == "b")
            {
                blueLight.SetActive(true);
            }
            else if (colour.ToString() == "g")
            {
                greenLight.SetActive(true);
            }
            else if (colour.ToString() == "y")
            {
                yellowLight.SetActive(true);
            }

            yield return new WaitForSeconds(1);

            if (colour.ToString() == "r")
            {
                redLight.SetActive(false);
            }
            else if (colour.ToString() == "b")
            {
                blueLight.SetActive(false);
            }
            else if (colour.ToString() == "g")
            {
                greenLight.SetActive(false);
            }
            else if (colour.ToString() == "y")
            {
                yellowLight.SetActive(false);
            }

            yield return new WaitForSeconds(0.5f);     //Wait before moving on to next colour
        }

        screenIsFlashing = false;
    }


    public void RedPressed()
    {
        if (screenIsFlashing)
        {
            return;     //Don't continue with the rest of the function if the screen is still flashing
        }

        playerInput += "r";
        CheckPlayerInput();
    }


    public void GreenPressed()
    {
        if (screenIsFlashing)
        {
            return;     //Don't continue with the rest of the function if the screen is still flashing
        }

        playerInput += "g";
        CheckPlayerInput();
    }


    public void BluePressed()
    {
        if (screenIsFlashing)
        {
            return;     //Don't continue with the rest of the function if the screen is still flashing
        }

        playerInput += "b";
        CheckPlayerInput();
    }


    public void YellowPressed()
    {
        if (screenIsFlashing)
        {
            return;     //Don't continue with the rest of the function if the screen is still flashing
        }

        playerInput += "y";
        CheckPlayerInput();
    }


    void CheckPlayerInput()
    {
        if (currentRoundCounter == 1 && playerInput.Length == round1Sequence.Length)
        {
            if (playerInput == round1Sequence)
            {
                currentRoundCounter++;
                playerInput = "";
                StartCoroutine("FlashLights", round2Sequence);
            }
            else
            {
                //Play sound indicating they were wrong?
                playerInput = "";
                currentRoundCounter = 1;
                StartCoroutine("FlashLights", round1Sequence);
            }
        }
        else if (currentRoundCounter == 2 && playerInput.Length == round2Sequence.Length)
        {
            if (playerInput == round2Sequence)
            {
                currentRoundCounter++;
                playerInput = "";
                StartCoroutine("FlashLights", round3Sequence);
            }
            else
            {
                //Play sound indicating they were wrong?
                playerInput = "";
                currentRoundCounter = 1;
                StartCoroutine("FlashLights", round1Sequence);
            }
        }
        else if (currentRoundCounter == 3 && playerInput.Length == round3Sequence.Length)
        {
            if (playerInput == round3Sequence)
            {
                currentRoundCounter++;
                playerInput = "";
                StartCoroutine("FlashLights", round4Sequence);
            }
            else
            {
                //Play sound indicating they were wrong?
                playerInput = "";
                currentRoundCounter = 1;
                StartCoroutine("FlashLights", round1Sequence);
            }
        }
        else if (currentRoundCounter == 4 && playerInput.Length == round4Sequence.Length)
        {
            if (playerInput == round4Sequence)
            {
                playerInput = "";
                print("You win!");
            }
            else
            {
                //Play sound indicating they were wrong?
                playerInput = "";
                currentRoundCounter = 1;
                StartCoroutine("FlashLights", round1Sequence);
            }
        }
    }
}