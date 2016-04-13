using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuHandler : MonoBehaviour {
    [SerializeField]
    private AudioSource Ad;

    public void StartGame() {
        SceneManager.LoadScene("FinalGameScene");
        Ad.Play();
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
        Ad.Play();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Ad.Play();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Ad.Play();
    }
    public void Quit()
    {
        Application.Quit();
        Ad.Play();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
