using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

	private Transform player;		// Reference to the player's transform.
	public float movementSpeed = 1f;

	void Awake ()
	{
		// Setting up the reference.
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void FixedUpdate ()
	{
		TrackPlayer();
	}

	void TrackPlayer ()
	{
		// By default the target x and y coordinates of the camera are it's current x and y coordinates.
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		targetX = Mathf.Lerp(transform.position.x, player.position.x, movementSpeed * Time.deltaTime);
		targetY = Mathf.Lerp(transform.position.y, player.position.y, movementSpeed * Time.deltaTime);

		// Set the camera's position to the target position with the same z component.
		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}
}