using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Create a code that will make a coin appear on a random position when the game starts, 
if its touched by the player, the coin will disappear and the player will get 1 point. 
Finally a new coin will appear on a random position on the top or bottom of the screen.
By: Francisco Martinez Gallardo and Rafael Blanga
Date: 09/03/2023
*/
public class CoinSummon : MonoBehaviour
{

   [SerializeField] GameObject coin;
   [SerializeField] ScoreCount scoreOb;

   // create a function to make the coin appear on a random position between -19.5 and 19.5 on the x-axis
   public void DropCoin(float y1, float y2){
      var position = new Vector3(Random.Range(-17f, 17f), Random.Range(y1,y2), Random.Range(0f, 0f)); // create a variable to store the position of the coin
      GameObject obj =  Instantiate(coin,position,Quaternion.identity);// create a variable to store the coin
    }

   private void OnCollisionEnter2D (Collision2D col) {
      // create a function to make the coin disappear when the player touches it
      if (col.gameObject.tag == "Player")
      {
         scoreOb.AddPoints(1); // add 1 point to the score when the player touches the coin

         if (scoreOb.score % 2 != 0) // make the coin appear on the bottom of the screen when the score is odd and on the top when the score is even
         {
            DropCoin(-7, -8); // make the coin appear on the bottom of the screen
         }
         else
         {
            DropCoin(7, 8); // make the coin appear on the top of the screen
         }

         Destroy(this.gameObject);// destroy the coin when the player touches it
      
      }
         


   }
}

