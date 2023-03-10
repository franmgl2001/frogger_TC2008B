using UnityEngine;

/*
This script will make the enemy move in the x-axis and rotate when it reaches the limit
By: Francisco Martinez Gallardo and Rafael Blanga

*/

public class EnemyMovement : MonoBehaviour
{
    
    // create code to rotate the enemy when it reaches the limit
    [SerializeField]float speed;
    [SerializeField]float limit;
    Vector3 move;

   

    void Update()
    {

        // Move the enemy in the x-axis
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Rotate the enemy when it reaches the limit and move in - speed to the opposite direction until it reaches the limit again
        if (transform.position.x > limit || transform.position.x < -limit)
        {
            
            speed = -speed;
            Vector3 rotationToAdd = new Vector3(0, 90, 0);
            transform.Rotate(rotationToAdd);

            transform.Translate(Vector2.right * speed * Time.deltaTime*5);
        }

        // Rotate the enemy when it reaches the limit and move in - speed to the opposite direction until it reaches the limit again
        

    }
}
