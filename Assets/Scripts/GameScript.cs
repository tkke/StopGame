using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public Text timeLabel;
	float timer = 0.0f;
	int flag = 0;
	public GameObject ball;

	// Use this for initialization
	void Start () {
		timeLabel.text = "Shoot Game";

	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 1) {
			timer += Time.deltaTime;
			timeLabel.text = timer.ToString ("f1");
			transform.localScale = new Vector3 (2, 2, 2) * timer;
			ball.transform.Rotate (new Vector3 (0, 10, 10));
		}
	}

	public void StartButton() {
		flag = 1;
		timer = 0.0f;
		ball.transform.position = new Vector3 (0, -3, -2);
	}

	public void StopButton() {
		flag = 0;
		if (4.90F < timer && timer < 5.10F) {
			timeLabel.text = "GOAL!";
			ball.transform.position += new Vector3 (0, 3, 7);
		} else {
			timeLabel.text = "MISS";
			ball.transform.position += new Vector3 (11, 9, 7);
		}
		timer = 0.0f;
	}

}


