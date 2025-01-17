using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject menuPause;
    bool gameIsPause = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        gameIsPause = true;
        Time.timeScale = 0f;
        menuPause.SetActive(true);
        Debug.Log("Pause game");
    }

    public void Resume()
    {
        gameIsPause = false;
        Time.timeScale = 1f;
        menuPause.SetActive(false);
        Debug.Log("Resume game");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restart game");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("I'm in the menu");
    }    
}
