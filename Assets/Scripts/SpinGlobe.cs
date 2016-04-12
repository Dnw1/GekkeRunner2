using UnityEngine;
using System.Collections;

public class SpinGlobe : MonoBehaviour {

	[SerializeField]
	private Vector3 rotationVector;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotationVector * Time.deltaTime);
	}
}
