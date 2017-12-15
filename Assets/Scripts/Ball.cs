using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody2D rb;
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (7f, 7f);
	}

	void Update () {
		if (this.transform.position.x >= 22) {
			this.transform.position = new Vector3 (0f,0f,0f);
		} else if (this.transform.position.x <= 22) {
			this.transform.position = new Vector3 (0f,0f,0f);
		}

	}
}
