﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;

	void FixedUpdate(){
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);
	}
}	