using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour {
	private Rigidbody2D rb;
	private float speed = 12f;

	public Text CountDown;
	public Rigidbody2D Pad1;
	public Rigidbody2D Pad2;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		StartCoroutine (move ());
	}

	void Update () {
		if (Mathf.Abs(this.transform.position.x) >= 22){
			this.transform.position = new Vector3 (0f,0f,0f);
			rb.velocity = new Vector2 (0f, 0f);
			StartCoroutine (move ());
		}
	}

	IEnumerator move(){
		for (int i = 3; i >= 0; i--) {
			if (i == 0) {
				CountDown.text = "";	
			} else {
				CountDown.text = i.ToString();
				yield return new WaitForSeconds (1);
			}
		}
		rb.velocity = new Vector2 (speed * random(true), speed * random(false));
	}

	int random(bool check){
		int RandNum = Random.Range (-1, 2);
		if (check && RandNum == 0) {
			RandNum ++;
		}
		return RandNum;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Paddle 1") {
			if (Pad1.velocity.y > 1f) {
				rb.velocity = new Vector2 (speed, speed);
			} else if (Pad1.velocity.y < -1f) {
				rb.velocity = new Vector2 (speed, -speed);
			} else {
				rb.velocity = new Vector2 (speed, 0);
			}
		} else if (col.gameObject.name == "Paddle 2") {
			if (Pad2.velocity.y > 1f) {
				rb.velocity = new Vector2 (-speed, speed);
			} else if (Pad2.velocity.y < - 1f) {
				rb.velocity = new Vector2 (-speed, -speed);
			} else {
				rb.velocity = new Vector2 (-speed, 0);
			}
		}
	}
}
