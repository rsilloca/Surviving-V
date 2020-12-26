using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    bool paused;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        this.paused = false;
     //   this.canvas = GetComponent<Canvas>();
        this.canvas.enabled = this.paused;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.paused = !this.paused;
            this.canvas.enabled = this.paused;
            Time.timeScale = (paused) ? 0 : 1;
        }
    }
}
