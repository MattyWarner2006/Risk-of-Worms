using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Popup_Ui : MonoBehaviour
{
    public Player_Movement player;
    public GameObject[] uiPopUps;
    public bool firstPopUp;
    public bool secondPopUp;
    public bool thirdPopUp;
    public bool fourthPopUp;
    public bool fifthPopUp;


    public void Start()
    {
        uiPopUps[0].SetActive(true);
        firstPopUp = true;
        Time.timeScale = 0;
    }
    public void DisableUi()
    {
        if (firstPopUp == true)
        {
            uiPopUps[0].SetActive(false);
        }

        if (secondPopUp == true)
        {
            uiPopUps[1].SetActive(false);
        }

        if (thirdPopUp == true)
        {
            uiPopUps[2].SetActive(false);
        }

        if (fourthPopUp == true)
        {
            uiPopUps[3].SetActive(false);
        }

        if (fifthPopUp == true)
        {
            uiPopUps[4].SetActive(false);
        }
        Time.timeScale = 1;
    }
    public void ShowUI()
    {
        if (Mathf.Approximately(player.score, 500))
        {
            uiPopUps[1].SetActive(true);
            secondPopUp = true;
            Time.timeScale = 0;
        }
        else if (Mathf.Approximately(player.score, 1000))
        {
            uiPopUps[2].SetActive(true);
            thirdPopUp = true;
            Time.timeScale = 0;
        }
        else if (Mathf.Approximately(player.score, 1500))
        {
            uiPopUps[3].SetActive(true);
            fourthPopUp = true;
            Time.timeScale = 0;
        }
        else if (Mathf.Approximately(player.score, 2000))
        {
            uiPopUps[4].SetActive(true);
            fifthPopUp = true;
            Time.timeScale = 0;
        }
        else if (Mathf.Approximately(player.score, 2500))
        {
            SceneManager.LoadScene(2);
        }
    }
    
    
}
