using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float verticcal;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
         horizontal = Input.GetAxis("Horizontal");
          vertical = Input.GetAxis("Vertical");
     
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical *Time.deltaTime;

        rigidbody2d.MovePosition (position);
    }
    private void FixedUpdate()
    {
        
    }
}
