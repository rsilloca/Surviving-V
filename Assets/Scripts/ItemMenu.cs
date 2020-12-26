using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ItemMenu : MonoBehaviour
{
    public float type = 0;
    Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                if (this.type == 0)
                {
                    SceneManager.LoadScene ("Level 1", LoadSceneMode.Single);
                }
                else if (this.type == 1)
                {
                    SceneManager.LoadScene ("Credits", LoadSceneMode.Single);
                }
                else if (this.type == 2)
                {
                    Application.Quit();
                } else if (this.type == 3)
                {
                    SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
                }
            }
        }
    }

}
