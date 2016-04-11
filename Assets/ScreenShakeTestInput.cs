using UnityEngine;
using System.Collections;

public class ScreenShakeTestInput : MonoBehaviour {
	[SerializeField]
	private ScreenShake screenShake;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKey (KeyCode.Space)) 
		{
			screenShake.StartShake ();
		}
	}
}
