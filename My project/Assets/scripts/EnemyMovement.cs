using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
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
        }

    }
}
