using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public AudioSource hoverSound;
    public AudioSource clickSound;
    public Image panel;
    public Text text;
    public int behavior_ID = -1;

    public void hover()
    {
        panel.color = new Color(128,128,128);
        this.playSound(this.hoverSound);
        this.text.color = new Color(33, 41, 203);
    }

    public void click()
    {
        panel.color = new Color(0, 0, 0);
        this.playSound(this.clickSound);
        this.text.color = new Color(255, 255, 255);
    }

    public void reset()
    {
        panel.color = new Color(255, 255, 255);
        this.text.color = new Color(0, 0, 0);
    }

    private void playSound(AudioSource audio)
    {
        if (audio != null)
        {
            audio.Play();
        }
    }
    void Update()
    {
        this.updateVolume(this.hoverSound);
        this.updateVolume(this.clickSound);
    }
    private void updateVolume(AudioSource audio)
    {
        if (audio != null)
        {
            audio.volume = MusicController.effectsVolume;
        }
    }

    public void behavior()
    {
        if (this.behavior_ID == 0)
        {
            SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
        }
        else if (this.behavior_ID == 1)
        {
            SceneManager.LoadScene("Credits", LoadSceneMode.Single);
        }
        else if (this.behavior_ID == 2)
        {
            Application.Quit();
        }
        else if (this.behavior_ID == 3)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        else if (this.behavior_ID == 4)
        {
            SceneManager.LoadScene("Controlls", LoadSceneMode.Single);
        }
    }
}
