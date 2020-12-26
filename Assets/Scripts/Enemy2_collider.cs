using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2_collider : MonoBehaviour {

    public Enemy2Script enemy2Script;
    bool hasCollided = false;
    float timer = 0;
    public float hasCollidedTime = 0.5f;

    private void OnTriggerStay2D(Collider2D collision){

        if(!hasCollided){
            if (collision.gameObject.CompareTag("Player")){
                Character_controller player = collision.GetComponent<Character_controller>();
                if(player){
                    player.gotDamaged(20);
                // player.restart();
                }
            //Debug.Log("colliding with player");
            }
            
            enemy2Script.retroceder();
            hasCollided = true;
            timer = hasCollidedTime;
        }
       
    }
        
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            hasCollided = false;
        }
    }
}
