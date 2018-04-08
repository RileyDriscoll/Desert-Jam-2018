﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMover : MonoBehaviour
{

    public float Speed = 0;
    public float Jump_Force_yAxis = 0;

    private bool isJumping = false;
    private bool foundFooting = false;
    private bool pulledDown = true;
    private Rigidbody2D rb;
    private float scaleX;
    private float scaleY;
    private bool doubleJump;
    private bool inJump;


    private Animator animator;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        animator = GetComponent<Animator>();
        doubleJump = false;
        inJump = false;

    }
    // adds force to jump upwards
    void GoUp()
    {
        rb.AddForce(new Vector2(0, Jump_Force_yAxis + 12.5f), ForceMode2D.Impulse);
        isJumping = false;
        pulledDown = true;
        animator.Play("FullJumpAnimation");
        animator.Play("FullJump2Animation");

    }

    // Constant gravity to pull down the player when NOT in contact with the collider of the 'platform GameObject'
    void goDown()
    {
        rb.AddForce(new Vector2(0, -1), ForceMode2D.Impulse);
        isJumping = false;
        pulledDown = true;
    }

    //checking if the object is in contact with the 'platform GameObject'
    void OnCollisionStay2D(Collision2D col)
    {
        GameObject obj = col.gameObject;
        if (obj.GetComponent<BoxCollider2D>().transform.position.y <= this.gameObject.transform.position.y)
        {
            if (obj.tag == "Floor") 
            {
                foundFooting = true;
                pulledDown = false;
                doubleJump = true;
                inJump = false;
                return;
            }
            else
            {
                foundFooting = false;
                pulledDown = true;
            }
        }
        else
        {
            return;
        }
    }

    void OnCollisionExit2D()
    {
        foundFooting = false;
        if (inJump)
        {
            animator.Play("FallingAnimation");
        }
        else {
            animator.Play("FullJumpAnimation");
        }
        pulledDown = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        

        //Right movement thorough Right arrow key
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 vehicleposition = new Vector3(transform.position.x * Time.deltaTime, transform.position.y, transform.position.z);
            vehicleposition.x = transform.position.x + Speed / 100;
            transform.position = vehicleposition;
            if (foundFooting && !pulledDown)
            {
                animator.Play("RunAnimation");
            }
            transform.localScale = new Vector2(scaleX, scaleY);


        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 vehicleposition = new Vector3(transform.position.x * Time.deltaTime, transform.position.y, transform.position.z);
            vehicleposition.x = transform.position.x - Speed / 100;
            transform.position = vehicleposition;
            if (foundFooting && !pulledDown)
            {
                animator.Play("RunAnimation");
            }
            transform.localScale = new Vector2(-scaleX, scaleY);
        }
        else
        {
            if (foundFooting && !pulledDown)
            {
                animator.Play("IdleAnimation");
            }
        }

        // Enabling Jump bool when Space is pressed
        transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        //Enabling OR disabling jump bool conditions
        if (isJumping && ((foundFooting && !pulledDown) || (doubleJump)))
        {
            if (!(foundFooting && !isJumping))
            {
                pulledDown = false;
                rb.velocity = new Vector2(rb.velocity.x, 0);
                doubleJump = false;
            }
            GoUp();
        }

        if (rb.velocity.y < 0) {
            inJump = true;
        }

        //Enabling OR disabling gravity bool conditions
        if (!isJumping && !foundFooting && pulledDown)
        {

            goDown();
        }



    }
}
