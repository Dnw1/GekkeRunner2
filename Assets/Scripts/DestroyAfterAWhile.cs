using UnityEngine;
using System.Collections;

public class DestroyAfterAWhile : MonoBehaviour {

	[SerializeField]
	private float destroyTime;

	void Start () 
	{
		StartCoroutine (DestroyMe ());

	}

	private IEnumerator DestroyMe()
	{
		yield return new WaitForSeconds (destroyTime);
		Destroy (this.gameObject);
	}

}
