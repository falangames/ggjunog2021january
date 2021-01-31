using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public static TaskManager Instance;

    public GameObject InGamePanel;
    public GameObject PausePanel;
    public GameObject TaskPanel;
    public GameObject TaskText;
    public string TaskName;
    public string TaskString;

    private void Start()
    {
        Instance = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            InGamePanel.SetActive(false);
            TaskPanel.SetActive(true);
            PausePanel.SetActive(false);
            TaskText.SetActive(true);

            if (TaskName == this.name)
            {
                TaskText.GetComponent<Text>().text = TaskString;
            }
            if (TaskName == this.name)
            {
                TaskText.GetComponent<Text>().text = TaskString;
            }
            //Destroy(this.gameObject);
            PlayerController.Instance.controlIsActive = false;
        }
    }


    public void OnClick_ExitParch()
    {
        Time.timeScale = 1;
        TaskPanel.SetActive(false);
        InGamePanel.SetActive(true);
        PausePanel.SetActive(false);
        PlayerController.Instance.controlIsActive = true;
        dst();
    }

    public void dst()
    {
        Destroy(this.gameObject);
    }
}
