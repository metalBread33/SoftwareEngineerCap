using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jump_up = 16f;
    private bool is_Right = true;

    //connects to the Rigidbody 2D in unity 
    [SerializeField] private Rigidbody2D rb;

    //connects to ground check in unity to know when the character is "touching" the ground
    [SerializeField] private Transform onGround;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");

        //if we are on the ground then it sets our jump_up power to our y value to go up
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jump_up);
        }

        //if you are still holding onto the the button as we are moving up then we can jump a bit higher
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }


    //This checks if we are grounded, if true then the player can jump again
    private bool IsGrounded()
    {
        //works by making a invisible circle at feet, if it touches the ground then
        //it returns true
        return Physics2D.OverlapCircle(onGround.position, 0.2f, groundLayer);
    }


    //This is to make the character face the other way if they turn 
    private void Flip()
    {
        if (is_Right && horizontal < 0f || !is_Right && horizontal > 0f)
        {
            is_Right = !is_Right;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
