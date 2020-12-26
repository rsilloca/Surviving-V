using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseScreenScriipt : MonoBehaviour
{
    public string[] story;
    public Text text;
    private int index;
    /*= new {"¡Te contagiaste y te convertiste en zombie!", 
        "Animo hay gente que cuenta contigo.", 
        "Vuelve a intentarlo"};*/
    // Start is called before the first frame update
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
                string currentText = this.text.text;
                this.text.text = currentText + "\n" +story[index];
                this.index++;
            } else
            {  
                string currentText = this.text.text;
                SceneManager.LoadScene(LevelLabelScript.label);
            }

        }
    }
}
