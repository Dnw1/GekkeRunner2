using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuHandler : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene("Game");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
