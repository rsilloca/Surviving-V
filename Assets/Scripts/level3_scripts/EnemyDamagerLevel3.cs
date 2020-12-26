using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamagerLevel3 : MonoBehaviour
{
    public int damage;
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Character_controller player = collision.GetComponent<Character_controller>();
            if (player)
            {
                player.gotDamaged(damage);
                // player.restart();
            }
        }
    }

     private void OnTriggerExit2D(Collider2D collision) { 
        if (collision.gameObject.CompareTag("Player"))
        {
            Character_controller player = collision.GetComponent<Character_controller>();
            if (player)
            {
                player.gotDamaged(-2*damage/3);
                // player.restart();
            }
        }

    }
}
