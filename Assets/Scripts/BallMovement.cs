using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour {
	private Rigidbody2D rb;
	private float speed = 12f;

	public Text CountDown;
	public Rigidbody2D Pad1;
	public Rigidbody2D Pad2;
	public Text Ply1Score;
	public Text Ply2Score;

	void Start () {
		string scenen = SceneManager.GetActiveScene ().name;
		switch (scenen) {
		case "Scene1":
			speed = 14f;
			break;
		case "Scene2":
			speed = 16f;
			break;
		case "Scene3":
			speed = 18f;
			break;
		default:
			break;
		}
		rb = GetComponent<Rigidbody2D> ();
		StartCoroutine (move ());
	}

	void Update () {
		if (this.transform.position.x >= 22) {
			this.transform.position = new Vector3 (0f, 0f, 0f);
			rb.velocity = new Vector2 (0f, 0f);
			StartCoroutine (move ());
			ScoreManager.checkScore (1);
			Ply1Score.text = ScoreManager.P1.ToString();
		} else if (this.transform.position.x <= -22) {
			this.transform.position = new Vector3 (0f, 0f, 0f);
			rb.velocity = new Vector2 (0f, 0f);
			StartCoroutine (move ());
			ScoreManager.checkScore (2);
			Ply2Score.text = ScoreManager.P2.ToString();
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
		float p1 = this.transform.position.y - GameObject.Find ("Paddle 1").transform.position.y;
		float p2 = this.transform.position.y - GameObject.Find ("Paddle 2").transform.position.y;
		if (col.gameObject.name == "Paddle 1") {
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, p1 * 2f);
		}
		if (col.gameObject.name == "Paddle 2") {
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, p2 * 2f);
		}
	}
}
