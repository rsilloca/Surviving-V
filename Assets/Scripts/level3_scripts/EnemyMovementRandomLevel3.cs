using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementRandomLevel3 : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody2d;
    float timer;
    public float changeTimeMax = 3.5f;
    public float changeTimeMin = 2.5f;
    public Animator animator;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = Random.Range(this.changeTimeMin, this.changeTimeMax); 
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = Random.Range(this.changeTimeMin, this.changeTimeMax); 
            int direction = (int)Random.Range(0, 4);
            Vector2 position = rigidbody2d.position;
            float movement = Time.deltaTime * speed;
            if (direction == 0)
            {
                position.y = position.y + movement;
                animator.SetTrigger("walking_up");

            }
            else if (direction == 1)
            {
                position.y = position.y - movement;
                animator.SetTrigger("walking_down");
            }
            else if (direction == 2)
            {
                position.x = position.x + movement;
                animator.SetTrigger("walking_rigth");
            }
            else if (direction == 3)
            {
                position.x = position.x - movement;
                animator.SetTrigger("walking_left");
            }

            rigidbody2d.MovePosition(position);
        }
    }
}
