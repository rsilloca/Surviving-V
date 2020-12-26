using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thinker : MonoBehaviour
{
    public float time_interval = 10.0f;
    public DialogueControllerLevel3 dialogue;
    private float time = 0.0f;
    public string[] tougths;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= this.time_interval)
        {
            time = 0;
            if (this.tougths.Length > 0)
            {
                this.dialogue.setText(this.tougths[Random.Range(0, tougths.Length)]);
            }
        }
    }
}
