using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandWasherhealthy : MonoBehaviour
{
    public AudioSource audioData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Character_controller player = collision.GetComponent<Character_controller>();
            float health_plus = (player.maxHealth - player.currentHealth) / 2;
            player.gotDamaged((int)(-1 * health_plus));
            audioData.Play(0);
        }

    }

    void Update()
    {
        if (this.audioData != null)
        {
            this.audioData.volume = MusicController.effectsVolume;
        }
    }
}
