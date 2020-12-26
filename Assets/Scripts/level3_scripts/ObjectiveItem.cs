using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveItem : MonoBehaviour
{
    public int value = 1;
    public CollectorLevel3Script collector;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.collector.count += this.value;
            Destroy(this.gameObject);
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
