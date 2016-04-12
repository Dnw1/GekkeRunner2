using UnityEngine;
using System.Collections;

public class AddScorePosition : MonoBehaviour {
	[SerializeField]
	private float xPositionToAddScore;
    private float BeyondBorder = -11;
    public Score ScoreManager;
	private Vector2 startPosition;
    public int newScoreValue { get; private set; }

    void Start()
	{
		startPosition = this.transform.position;

	}
	void Update () 
	{
		if (this.transform.position.x >= xPositionToAddScore) 
		{
            ScoreManager.AddScore();
			this.transform.position = startPosition;
		}
        if (this.transform.position.x < BeyondBorder)
        {
            this.transform.position = startPosition;
        }
	}
}
