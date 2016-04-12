using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuHandler : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene("FinalGameScene");
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
    public void Quit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
