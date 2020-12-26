using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel3 : MonoBehaviour
{
    public int value = 1;
    public CollectorLevel3Script collector;
    public DialogueControllerLevel3 dialogue;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (this.collector.count >= this.collector.requiered)
            {
                SceneManager.LoadScene("Win Screen");
            } else
            {
                this.dialogue.setText("Aun no has encontrado los suministros, asi no podras ayudar a tu cuartel");
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
