using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    /*public GameObject bebe;
    public GameObject kunye;
    string tag;

    void Start()
    {
        tag = this.gameObject.name;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

        }
    }*/

    public float letterPause = 0.2f;
    public AudioClip typeSound1;
    public AudioClip typeSound2;

    string message;
    Text textComp;

    void Start()
    {
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }
    int a;
    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            a++;
            //if (typeSound1 && typeSound2)
            //    SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
        if (a == message.Length)
        {
            Debug.Log("Bitti");
        }
    }
}
