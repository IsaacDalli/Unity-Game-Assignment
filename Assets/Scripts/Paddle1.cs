﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour {
	private float speed = 8f;
	private Rigidbody2D rb;
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			rb.velocity = new Vector2 (0f, speed);
		} else if (Input.GetKey (KeyCode.S)) {
			rb.velocity = new Vector2 (0f, -speed);
		} else {
			rb.velocity = new Vector2 (0f, 0f);
		}
	}
}
