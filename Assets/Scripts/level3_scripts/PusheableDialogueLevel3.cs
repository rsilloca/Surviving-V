using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusheableDialogueLevel3 : MonoBehaviour
{
    public DialogueControllerLevel3 dialogue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (dialogue)
                dialogue.setText("Empuja las cajas para poder desplazarte libremente.");
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
