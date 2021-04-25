using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5;
    public float roationSpeed = 5;

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Vector2 moveDirectionSprite;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

    }

    private void FixedUpdate()
    {
        Move();

    }

    void ProcessInputs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        else
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            float rotation = -moveX * roationSpeed;
            transform.Rotate(Vector3.forward * rotation);
            moveDirection = new Vector2(moveX, moveY).normalized;
        }

    }

    private void Attack()
    {
        animator.SetTrigger("Attack");
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed);
        
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }


}
