using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureItemScript : MonoBehaviour
{
    public Character_controller character_Controller;
    public int value = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (character_Controller.currentHealth < character_Controller.maxHealth)
            {
                this.character_Controller.currentHealth += value;
                Destroy(this.gameObject);
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
