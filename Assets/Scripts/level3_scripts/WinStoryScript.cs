using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinStoryScript : MonoBehaviour
{
    public string[] story;
    public Text story_txt;
    public Text press_inidication;
    private int index; 
    void Start()
    {
        this.index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.index < this.story.Length)
            {
                this.story_txt.text = story[index];
                this.index++;
            }
            else
            {
                SceneManager.LoadScene("Credits");
            }

        }

        if (this.index >= this.story.Length)
        {
            this.press_inidication.text = "Presiona espacio para reiniciar el juego.";
        }
    }
}
