using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// create a code that will make a coin appear on a random position when the game starts, if its touched by the player, the coin will disappear and the player will get 1 point
public class coinappear : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] float delay;
    // Start is called before the first frame update
    void Start()
    {
        //repeat when a player touches the coin, the coin will disappear and the player will get 1 point, anda coin will appear on a random position
        DropCoin();

    }

    public void DropCoin(){
       var position = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f), Random.Range(-9.0f, 9.0f));
       GameObject obj =  Instantiate(coin,position,Quaternion.identity);
       //Destroy(obj, 6.0f);
    }


    
}