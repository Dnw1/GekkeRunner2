using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Score score1;
    public Text timerText;
    public int timer = 3500;
    // Use this for initialization

    void Start()
    {
    }
    void FixedUpdate () {
        UpdateTimer();
    }
    public void UpdateTimer()
    {
        timer--;
        TimerText();
        if (score1.score == 10)
        {
            SceneManager.LoadScene("Menu");
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
