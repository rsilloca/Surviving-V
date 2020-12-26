using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKitScript : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
             Character_controller player = collision.GetComponent<Character_controller>();
            if(player){
                player.addFirstAidKit();
                Destroy(gameObject);
            }
        }
 
    }

}
