using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbineSpinMinigame : MonoBehaviour
{
    float rotationSpeed = 1;     //Speed at which the turbine object rotates.
    public Transform rotationGoal = null;   //The rotation needed to complete the minigame, set in-engine.
    public GameObject turbineObject = null;     //Wind turbine game object, set in-engine.
    private float angleDifference;      //Difference between turbineObject and rotationGoal's angle.
    public Player player; //for quest step
    public GameObject arm;
    //public CharacterController charcontr; //for disabling movement of player



    void Start()
    {
        turbineObject.gameObject.transform.rotation = Quaternion.Euler(0,-110,0);      //Set initial rotation of wind turbine object
       // arm.SetActive(false);
       //player.isTurbining = true;
       // charcontr.enabled = false;
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))       //Right (clockwise) rotation
        {
            turbineObject.transform.Rotate(0, rotationSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     //Left (counter-clockwise) rotation
        {
            turbineObject.transform.Rotate(0, -rotationSpeed, 0);
        }


        angleDifference = Quaternion.Angle(turbineObject.transform.rotation, rotationGoal.rotation);
        //Check if turbine rotation Y = rotationGoal Y (or 5 degrees above/below)
        if (angleDifference < 5)
        {
            print("You win!");
            // charcontr.enabled = true;
            //player.isTurbining = false;
            //arm.SetActive(true);
            player.questStep = 10;
            Destroy(this.gameObject);
        }
    }
}