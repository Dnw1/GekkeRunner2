using UnityEngine;
using System.Collections;

public class AddScorePosition : MonoBehaviour {
	[SerializeField]
	private float xPositionToAddScore;

	private Vector2 startPosition;

	void Start()
	{
		startPosition = this.transform.position;

	}

	void Update () 
	{
		if (this.transform.position.x >= xPositionToAddScore) 
		{
			Debug.Log ("AddScore");
			this.transform.position = startPosition;
		}
	}
}
