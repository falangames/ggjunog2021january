using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartString : MonoBehaviour
{
    public float letterPause = 0.01f;
    public string message;
    Text textComp;
    int a;

    void Start()
    {
        message = "";
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }
    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            a++;
            if (letter == '.')
            {
                textComp.text = "";
            }
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
        if (a == message.Length)
        {
            PlayerController.Instance.controlIsActive = true;
        }
        else if (a < message.Length)
        {
            PlayerController.Instance.controlIsActive = false;
        }
        else
        {
            PlayerController.Instance.controlIsActive = false;
        }
    }
}
