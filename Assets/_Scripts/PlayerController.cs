using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public Text scoreText;
	private int score;
	void Start () {
		score = 0;
	}
	void Update() {
		updateScore ();
	}
	public void updateScore()
	{
		score++;
	}
	void showScore()
	{
		scoreText.text = " "+scoreText.ToString ();
	}


}
