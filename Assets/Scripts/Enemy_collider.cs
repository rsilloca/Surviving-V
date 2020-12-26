using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_collider : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision){
        
        if (collision.gameObject.CompareTag("Player")){
            Character_controller player = collision.GetComponent<Character_controller>();
            if(player){
                player.gotDamaged(20);
               // player.restart();
            }
        }
 
    }
}
