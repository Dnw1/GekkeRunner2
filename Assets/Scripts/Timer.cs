using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Score score1;
	public Score score2;
    public Text timerText;
    public int timer = 3500;
    // Use this for initialization

    void Start()
    {
    }
    void Update () {
        UpdateTimer();
    }
    public void UpdateTimer()
    {
        timer--;
        TimerText();
        if (score1.score == 10)
        {
			SceneManager.LoadScene("Player1Wins");
        }
		else if (score2.score == 10)
		{
			SceneManager.LoadScene("Player 2 Wins");
		}
        else if (timer == 0)
        {
            SceneManager.LoadScene("Menu");
        }

    }
    void TimerText()
    {
        timerText.text = "Timer: " + Mathf.Round(timer / 100f);
    }
}
