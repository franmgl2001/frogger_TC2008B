//Move the basket horizontally using the arrow keys or AD to catch the falling balls

//Rafael Blanga Hanono and Francisco Martinez Gallardo 2023-03-01

//import the libraries needed to make the code work
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Define Variables for the movement of the player
    [SerializeField]float speed; // speed of the player
    [SerializeField]float limitx; // limit of the player in the x-axis
    [SerializeField]float limity; // limit of the player in the y-axis
    Vector3 move; // vector to move the player


    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal"); // get the input of the horizontal axis
        move.y = Input.GetAxis("Vertical"); // get the input of the vertical axis

        //limit movement in the x-axis to a specific range of coordinates
        if (transform.position.x < -limitx && move.x < 0)
        {
            move.x = 0;
        }
        else if (transform.position.x > limitx && move.x > 0)
        {
            move.x = 0;
        }
        // limit movement in the y-axis to a specific range of coordinates
        if (transform.position.y < -limity && move.y < 0)
        {
            move.y = 0;
        }
        else if (transform.position.y > limity && move.y > 0)
        {
            move.y = 0;
        }

        // Movement of the player.
        transform.Translate(move * Time.deltaTime * speed);
    }
}
