using UnityEngine;

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

      
        if (transform.position.x > limit || transform.position.x < -limit)
        {
            speed = -speed;
             Vector3 rotationToAdd = new Vector3(0, 90, 0);
             transform.Rotate(rotationToAdd);
            
            
            

        }

        // Rotate the enemy when it reaches the limit and move in - speed to the opposite direction until it reaches the limit again
        

    }
}
