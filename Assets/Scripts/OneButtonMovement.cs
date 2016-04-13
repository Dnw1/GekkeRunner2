using UnityEngine;
using System.Collections;

public class OneButtonMovement : MonoBehaviour {

	[SerializeField]
	private KeyCode keyCode;

	[SerializeField]
	private float movementSpeed;

	private Vector2 movementVector;

	void Start()
	{
		movementVector = new Vector2 (movementSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(keyCode)) {
			transform.Translate(movementVector*Time.deltaTime, Space.World);
		}
	
	}
}
