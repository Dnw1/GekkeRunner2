using UnityEngine;
using System.Collections;

public class PlayerObstacleCollision : MonoBehaviour {

	[SerializeField]
	private ScreenShake screenShake;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == TagData.obstacleTag) 
		{
			Debug.Log ("AUW");
			screenShake.StartShake ();
		}
	}
}
