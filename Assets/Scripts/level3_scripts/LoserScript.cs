using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoserScript : MonoBehaviour
{
    public Character_controller player;
    public HealthBarScript healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.healthBar.SetHealth(this.player.currentHealth);
        if (this.player.currentHealth<=0)
        {
            SceneManager.LoadScene("Lose Screen");
        }
    }
}
