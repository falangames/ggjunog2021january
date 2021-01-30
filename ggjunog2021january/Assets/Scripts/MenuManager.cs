using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject InGamePanel;
    public GameObject PausePanel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClick_PlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }
    public void OnClick_InfoButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("InfoScene");
    }
    public void OnClick_HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }
    public void OnClick_PauseButton()
    {
        InGamePanel.SetActive(false);
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnClick_ContinueButton()
    {
        Time.timeScale = 1;
        InGamePanel.SetActive(true);
        PausePanel.SetActive(false);
    }
}
