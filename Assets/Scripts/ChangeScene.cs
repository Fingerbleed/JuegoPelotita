using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void Change(string sceneName)
    {
        if(sceneName == "Exit") {
            Application.Quit();
        } else {
            SceneManager.LoadScene(sceneName);
        }
    }
}
