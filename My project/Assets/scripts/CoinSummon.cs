using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* create a code that will make a coin appear on a random position when the game starts, 
if its touched by the player, the coin will disappear and the player will get 1 point
By: Francisco Martinez Gallardo and Rafael Blanga
Date: 09/03/2023
*/
public class CoinSummon : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] ScoreCount scoreOb;

   // create a function to make the coin appear on a random position between -19.5 and 19.5 on the x-axis
    public void DropCoin(float y1, float y2){
       var position = new Vector3(Random.Range(-19.5f, 19.5f), Random.Range(y1,y2), Random.Range(0f, 0f));
       GameObject obj =  Instantiate(coin,position,Quaternion.identity);
    }

   private void OnCollisionEnter2D (Collision2D col) {
      
      if (col.gameObject.tag == "Player")
      scoreOb.AddPoints(1);
      if (scoreOb.score % 2 != 0){
         DropCoin(-7, -9);

      }
      else{
         DropCoin(7, 9);

      }

      Destroy(this.gameObject);
   }
}

    // public void StopSpawning(){
       // create a function to stop the game when the player gets 10 points
     //}
