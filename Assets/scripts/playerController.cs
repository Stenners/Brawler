using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public Animator anim;
	//public tr attacking = false;
	public bool facingRight = true;
	//public bool jump = false;
	//public float jumpForce = 20;
	public Vector2 speed = new Vector2(4, 2);
	private Vector2 movement;

	
	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetButton ("Fire1")) {
			anim.Play ("punching");
			anim.SetTrigger("attacking");
		}
	}

	void FixedUpdate () {

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		movement = new Vector2(
			speed.x * h,
			speed.y * v);
		
		// If the input is moving the player right and the player is facing left...
		if(h > 0 && !facingRight)
			// ... flip the player.
			Flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		else if(h < 0 && facingRight)
			// ... flip the player.
			Flip();

		// The Speed animator parameter is set to the absolute value of the horizontal input.
		anim.SetFloat("SpeedX", Mathf.Abs(h));
		anim.SetFloat("SpeedY", Mathf.Abs(v));

		rigidbody2D.velocity = movement;

	}
	
	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
}