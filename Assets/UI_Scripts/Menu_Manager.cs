using UnityEngine; 
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu_Manager : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject controlsPanel;
    public bool controlsPanelActive;
    
    public Button BeginButton;
    public Button ControlsButton;
    public Button EndButton;

    public void ToggleControlsPanel()
    {
        if (controlsPanelActive)
        {
            menuPanel.SetActive(true);
            controlsPanel.SetActive(false);
        }
        else
        {
            menuPanel.SetActive(false);
            controlsPanel.SetActive(true);
        }
        controlsPanelActive = !controlsPanelActive;
    }

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
