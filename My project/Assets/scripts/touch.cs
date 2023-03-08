using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    [SerializeField] scoree scoreObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Detect two elements colliding
    void OnTriggerEnter2D()
    {
        scoreObj.AddPoints(1);
        
    }
}
