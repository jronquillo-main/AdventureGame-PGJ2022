using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 11;
    private Rigidbody2D rb;
    private Vector3 change;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        change = Vector2.zero;
        //input
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(change!= Vector3.zero)
        {
            Move();
        }
    }

    void Move()
    {
        rb.MovePosition(transform.position + change.normalized * speed * Time.deltaTime);
    }
}
