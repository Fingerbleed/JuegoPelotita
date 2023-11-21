using UnityEngine;
using UnityEngine.SceneManagement;


public class GameChangeScene : MonoBehaviour
{
    public string sceneName;
    public void Change()
    {
        if(sceneName == "Exit") {
            Application.Quit();
        } else {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Change();
    }
}
