using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;
    

    Rigidbody2D rigidbody2d;
    float timer;
    int direction = 1;
    
    Animator animator;
    bool walking = false;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
        walking = true;
    }

    void Update()
    {
        animator.SetBool("walking",walking);
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
            transform.Rotate(0,180,0);
        }
    }
    
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }
        
        rigidbody2d.MovePosition(position);
    }

}
