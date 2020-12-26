using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour {
    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;
    int random_number = 0;

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
            random_number =  Random.Range(0,4);
            switch(random_number){
                case 0: 
                    vertical = true;direction=1; break;
                case 1:
                    vertical = false;direction=1; break;
                case 2:
                    vertical = true;direction=-1;transform.Rotate(0,180,0); break;
                case 3:
                    vertical = false;direction=-1;transform.Rotate(0,180,0); break;
                default: break;
            }

            direction = -direction;
            timer = changeTime;
            
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
    
    public void retroceder(){
        if(direction == 1){direction=-1;}
        else{
            if(direction ==-1){direction=1;}
        }
        StartCoroutine("changeDirection",0.2f);

    }

    IEnumerator changeDirection(float Count){
        yield return new WaitForSeconds(Count); //Count is the amount of time in seconds that you want to wait.
        //And here goes your method of resetting the game...
        random_number =  Random.Range(0,4);
            switch(random_number){
                case 0: 
                    vertical = true;direction=1; break;
                case 1:
                    vertical = false;direction=1; break;
                case 2:
                    vertical = true;direction=-1;transform.Rotate(0,180,0); break;
                case 3:
                    vertical = false;direction=-1;transform.Rotate(0,180,0); break;
                default: break;
            }
        yield return null;
    } 
}