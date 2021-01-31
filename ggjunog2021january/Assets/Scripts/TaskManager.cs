using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public GameObject InGamePanel;
    public GameObject PausePanel;
    public GameObject TaskPanel;
    public GameObject TaskText;
    public string TaskName;
    public string TaskString;

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
            Destroy(this.gameObject);
            PlayerController.Instance.controlIsActive = false;
        }
    }
}
