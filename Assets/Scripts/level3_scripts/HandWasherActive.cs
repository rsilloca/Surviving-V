using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandWasherActive : MonoBehaviour
{
    public Character_controller player;
    public HandWasherhealthy healthy;
    
    void Update()
    {
        if (player.currentHealth < player.maxHealth)
        {
            healthy.gameObject.active = true;
        } else
        {
            healthy.gameObject.active = false;
        }
    }
}
