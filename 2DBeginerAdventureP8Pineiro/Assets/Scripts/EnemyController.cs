using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerr : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D Rigidbody2D;

    bool broken;

    float timer;
    int direction = 1;
    object animator;

    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!broken)
        {
            return;
        }
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }
    void FixedUpdate()
    {
        if(!broken)
        {
            return;
        }
        Vector2 position = Rigidbody2D.position;
        if (vertical)
        {
            
        }
        else
        {
            
        }



        Rigidbody2D.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player !=null)
        {
            player.ChangeHealth(-1);
        }
    }

    public void Fix()
    {
       broken = false;
        Rigidbody2D.simulated = false;
        
    }
}
