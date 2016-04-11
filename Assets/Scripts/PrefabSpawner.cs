using UnityEngine;
using System.Collections;

public class PrefabSpawner : MonoBehaviour {
	
	[SerializeField]
	private float maxX;

	[SerializeField]
	private float minX;

	[SerializeField]
	private float spawnInterval;

	[SerializeField]
	private GameObject gameObjectPrefab;

	void Start()
	{
		StartCoroutine (Spawn ());
	}


	private IEnumerator Spawn()
	{
		yield return new WaitForSeconds (spawnInterval);
		Instantiate(gameObjectPrefab,new Vector2(Random.Range(minX,maxX),this.transform.position.y),Quaternion.identity);
		StartCoroutine (Spawn ());
	}
}
