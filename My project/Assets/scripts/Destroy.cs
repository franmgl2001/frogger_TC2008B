using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] coinappear rafa;
    // Start is called before the first frame update
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coin"){
       Destroy(col.gameObject);
       rafa.DropCoin();
        }
    }

}