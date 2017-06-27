using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float jumpHeight;
	public float speed;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private Rigidbody2D rgb;

	void Start ()
	{
		rgb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	void Update ()
	{
        Movement();
    }

    void Movement()
    {
        if (Input.GetButtonDown("Jump") && grounded)
            rgb.velocity = new Vector2(0, jumpHeight);

        rgb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rgb.velocity.y);
    }
}