using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class ChangeSceneAfterTime : MonoBehaviour {

	[SerializeField]
	private  float timeToWait;

	[SerializeField]
	private string sceneToLoad;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (ChangeScene ());
	}
	
	IEnumerator ChangeScene()
	{
		yield return new WaitForSeconds(timeToWait);

		SceneManager.LoadScene (sceneToLoad);
	}
}
