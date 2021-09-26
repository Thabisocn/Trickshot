using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 5;
    public float jumpSpeed = 5;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
 
        moveLeft = false;
        moveRight = false;
    }
 
    //I am pressing the left button
    public void PointerDownLeft()
    {
        moveLeft = true;
    }
 
    //I am not pressing the left button
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
 
    //Same thing with the right button
    public void PointerDownRight()
    {
        moveRight = true;
    }
 
    public void PointerUpRight()
    {
        moveRight = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }
 
    //Now let's add the code for moving
    private void MovementPlayer()
    {
        //If i press the left button
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
 
        //if i press the right button
        else if (moveRight)
        {
            horizontalMove = speed;
        }
 
        //if i am not pressing any button
        else
        {
            horizontalMove = 0;
        }
    }
 
    public void jumpButton()
    {
        if(rb.velocity.y == 0)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }
 
    //add the movement force to the player
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}
