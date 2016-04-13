using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Player") {
			animator.SetTrigger ("HitPlane");
			Destroy (gameObject, 0.7f);
	}
	}
}