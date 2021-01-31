using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public float letterPause = 0.2f;

    string message;
    Text textComp;

    public GameObject parchExitButton;
    int a;

    void Start()
    {
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
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
        if (a == message.Length)
        {
            parchExitButton.SetActive(true);
        }
        else
        {
            parchExitButton.SetActive(false);
        }
    }
}
