using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public GUIText scoreText;
	private int score;
    [SerializeField]
    public float timer;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (score == 10)
        {
            SceneManager.LoadScene{ (/*scenenaam*/)}
        }
        else if (timer == 120000)
        {
            SceneManager
        }
	}
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	 }
}
