using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    /*public float letterPause = 0.01f;

    public string message;
    Text textComp;
    public GameObject parchExitButton;
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
    }*/

    /*void OnEnable()
    {
        StartCoroutine(TypeText());
    }*/

    /*public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    public GameObject parchExitButton;

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        int i = 0;
        for (i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }

        if (i == fullText.Length)
        {
            parchExitButton.SetActive(true);
        }
        else
        {
            parchExitButton.SetActive(false);
        }
    }*/
    /*Text txt;
    string story;
    public GameObject parchExitButton;
    int a;

    void Awake()
    {
        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";

        // TODO: add optional delay when to start
        StartCoroutine("PlayText");
    }

    IEnumerator PlayText()
    {
        foreach (char c in story)
        {
            a++;
            txt.text += c;
            yield return new WaitForSeconds(0.125f);
        }

        if (a == story.Length)
        {
            parchExitButton.SetActive(true);
        }
        else
        {
            parchExitButton.SetActive(false);
        }
    }*/

    /*public string textShownOnScreen;
    public string fullText = "The text you want shown on screen with typewriter effect.";
    public float wordsPerSecond = 2; // speed of typewriter
    private float timeElapsed = 0;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        textShownOnScreen = GetWords(fullText, timeElapsed * wordsPerSecond);
    }

    private string GetWords(string text, int wordCount)
    {
        int words = wordCount;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                words--;
            }
            if (words <= 0)
            {
                return text.Substring(0, i);
            }
        }
        return text;
    }*/
    public Text text;
    public GameObject parchExitButton;

    void Start()
    {
        StartCoroutine(RevealText());
    }

    IEnumerator RevealText()
    {
        var originalString = text.text;
        text.text = "";

        var numCharsRevealed = 0;
        while (numCharsRevealed < originalString.Length)
        {
            while (originalString[numCharsRevealed] == ' ')
                ++numCharsRevealed;

            ++numCharsRevealed;

            text.text = originalString.Substring(0, numCharsRevealed);

            yield return new WaitForSeconds(0.07f);
        }

        if (numCharsRevealed == text.text.Length)
        {
            parchExitButton.SetActive(true);
        }
        else
        {
            parchExitButton.SetActive(false);
        }
    }
}
