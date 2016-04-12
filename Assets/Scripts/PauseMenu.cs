﻿using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class PauseMenu : MonoBehaviour
{

    bool isShowing, Esc;

    [SerializeField]
    CanvasGroup pauseMenuContainer;
    GameObject CheckCanvas;


    void Start()
    {
        //pauseMenuContainer.GetComponent<CanvasGroup>();
        //CheckCanvas.SetActive(isShowing);
    }
    void Update()
    {
        CheckIfPaused();
    }
    void CheckIfPaused()
    {
        Debug.Log("check1");
        if (Esc = Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("check2");
            //CheckCanvas.SetActive(isShowing = true);
            Time.timeScale = 0.0f;
            pauseMenuContainer.alpha = 1;
            pauseMenuContainer.interactable = true;
            pauseMenuContainer.blocksRaycasts = true;
        }
    }

    public void TogglePause()
    {
            //isShowing = false;
            Time.timeScale = 1.0f;
            pauseMenuContainer.alpha = 0;
            pauseMenuContainer.interactable = false;
            pauseMenuContainer.blocksRaycasts = false;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
    public void Quit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}