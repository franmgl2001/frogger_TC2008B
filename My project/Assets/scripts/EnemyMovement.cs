using UnityEngine;

/*
This script will make the enemy move in the x-axis and rotate when it reaches the limit
By: Francisco Martinez Gallardo and Rafael Blanga

*/

public class EnemyMovement : MonoBehaviour
{
    
    // create code to rotate the enemy when it reaches the limit
    [SerializeField]float limit;
    [SerializeField] ScoreCount scoreOb;
    [SerializeField] float speed;
    Vector3 move;
    float final_speed;

   

    void Update()
    {
        final_speed = speed + (scoreOb.score * 2); // increase the speed of the enemy when the player gets more points

        // Move the enemy in the x-axis
        transform.Translate(Vector2.right * final_speed * Time.deltaTime);

        // Rotate the enemy when it reaches the limit and move in - speed to the opposite direction until it reaches the limit again
        if (transform.position.x > limit || transform.position.x < -limit)
        {
            
            speed = -speed; // change the direction of the enemy
            Vector3 rotationToAdd = new Vector3(0, 90, 0); // rotate the enemy
            transform.Rotate(rotationToAdd); // rotate the enemy

            transform.Translate(Vector2.right * speed * Time.deltaTime*10);
        }

        // Rotate the enemy when it reaches the limit and move in - speed to the opposite direction until it reaches the limit again

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            scoreOb.AddPoints(-3);
        }
    }
    
}

