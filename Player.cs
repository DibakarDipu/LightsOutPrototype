using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2 (3, 5);
	public bool standing;
	public float jumpSpeed = 15f;

	public bool freezeRotation;

	void FixedUpdate(){
		freezeRotation = true;
	}

	void Update () {
		var forceX = 0f;
		var forceY = 0f;

		var absVelX = Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x);
		var absVelY = Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.y);

		if (absVelY < 0.2f) {
			standing = true;
		} else {
			standing = false;
		}

		if (Input.GetKey ("right")) {
			if (absVelX < maxVelocity.x)
				forceX = speed;

			transform.localScale = new Vector3 (1, 1, 1);
		} else if (Input.GetKey ("left")) {
			if (absVelY < maxVelocity.x)
				forceX = -speed;

			transform.localScale = new Vector3 (-1, 1, 1);
		}

		if (Input.GetKey ("space")) {
			if (absVelY < maxVelocity.y)
				forceY = jumpSpeed;
		}

		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (forceX, forceY));
	}
}
