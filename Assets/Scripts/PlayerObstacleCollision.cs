using UnityEngine;
using System.Collections;

public class PlayerObstacleCollision : MonoBehaviour {

	[SerializeField]
	private ScreenShake screenShake;

	private Vector2 startPosition;

	void Start()
	{
		startPosition = this.transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == TagData.obstacleTag) 
		{
			Debug.Log ("AUW");
			screenShake.StartShake ();
			this.transform.position = startPosition;
		}
	}
}
