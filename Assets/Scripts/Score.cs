using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	
	}
    public void AddScore()
	{
        Debug.Log(score);
		score ++;
		UpdateScore ();
	}
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	 }
}
