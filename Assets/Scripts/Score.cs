﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text scoreText;
	public int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	
	}
    public void AddScore()
	{
		score ++;
		UpdateScore ();
	}
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	 }
}
