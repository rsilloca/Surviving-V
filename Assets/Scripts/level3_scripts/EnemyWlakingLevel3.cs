using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWlakingLevel3 : MonoBehaviour
{
    public Animator animator;
    public float velocity;
    public float acceleration;
    private float time = 0.0f;
    public float interpolationPeriod = 5.0f;
    bool walking = false;

    // Start is called before the first frame update
    void Start()
    {
        this.walking = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0;
            int direction = (int)Random.Range(0.0f, 4.0f);
            if (direction == 0)
            {
                transform.position += Vector3.left * velocity * Time.deltaTime;
                this.velocity += acceleration;
            }
            if (direction == 1)
            {
                transform.position += Vector3.right * velocity * Time.deltaTime;
                this.velocity += acceleration;
            }
            if (direction == 2)
            {
                transform.position += Vector3.down * velocity * Time.deltaTime;
                this.velocity += acceleration;
            }
            if (direction == 3)
            {
                transform.position += Vector3.up * velocity * Time.deltaTime;
                this.velocity += acceleration;
            }
        }
        transform.rotation = Quaternion.identity;
        animator.SetBool("walking", walking);               

    }
}
