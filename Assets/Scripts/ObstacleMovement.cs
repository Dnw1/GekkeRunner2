using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {

	[SerializeField]
	private float fallingSpeed;

	private Vector2 fallingVector;

	void Start()
	{
		fallingVector = new Vector2 (0, -fallingSpeed);
	}

	void Update () 
	{
		transform.Translate(fallingVector*Time.deltaTime, Space.World);
	}
}
