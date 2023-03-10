using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
create a code that will make a coin appear on a random position on coliision with the player
By: Francisco Martinez Gallardo and Rafael Blanga
Date: 09/03/2023
*/
public class Destroy : MonoBehaviour
{
    [SerializeField] coinappear apearer;
    [SerializeField] scoree scoreOb;
    // Start is called before the first frame update
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coin"){
       Destroy(col.gameObject);
        apearer.DropCoin();
        scoreOb.AddPoints(1);
        }
        
    }

}