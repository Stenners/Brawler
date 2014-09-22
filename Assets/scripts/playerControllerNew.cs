using UnityEngine;
using System.Collections;

public class playerControllerNew : MonoBehaviour {

	public Animator anim;
	public bool facingRight = true;
	private Vector2 movement;
	public Vector2 speed = new Vector2(4, 2);

	void Awake() {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		Movement ();
		Attacking ();
	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}

	void Movement() {

		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2(speed.x * inputX, speed.y * inputY);

		if (inputX > 0) {
			transform.localScale = new Vector3(1, transform.localScale.y,1);
		} else if (inputX < 0) {
			transform.localScale = new Vector3(-1, transform.localScale.y,1);
		}
		/*if (v>0) {
			transform.Translate (Vector2.up * 1f * Time.deltaTime);
		} else if (v<0) {
			transform.Translate (-Vector2.up * 1f * Time.deltaTime);
		}*/
		anim.SetFloat("SpeedX", Mathf.Abs(inputX));
		anim.SetFloat("SpeedY", Mathf.Abs(inputY));
	}

	void Attacking() {
		if (Input.GetButton ("Fire1")) {
			anim.Play ("attack01");
			anim.SetTrigger("attacking");
		}
	}

}
