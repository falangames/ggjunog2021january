using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask whatIsGround;
    public float jumpForce;
    public float speed;
    Rigidbody2D rb;
    public float distance = 1.0f;
    public float delayInSeconds = 0.5f;

    bool canJump = true;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w") && IsGrounded() && canJump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
            StartCoroutine(ShootDelay());
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
        rb.velocity = move;
    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, whatIsGround);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        canJump = true;
    }
}
