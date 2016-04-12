using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Score score1;
    public int timer;
    // Use this for initialization

    void Start()
    {
    }
    void Update () {
        UpdateTimer();
        timer ++;
    }
    public void UpdateTimer()
    {
        Debug.Log(timer);
        if (score1.score == 9)
        {
            SceneManager.LoadScene("Menu");
        }
        else if (timer == 3200)
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
