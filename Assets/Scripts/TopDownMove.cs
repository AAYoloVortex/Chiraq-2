using System;
using UnityEngine;

public class TopDownMove : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float moveSpeed = 5f;
    bool isFacingRight = false;
    public float jumpPower = 0f;
    bool isGrounded = false;

    Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        FlipSprite();


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
    }

    void FlipSprite()
    {
        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }
}
