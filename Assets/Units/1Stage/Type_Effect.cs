using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Effect : MonoBehaviour
{
    public int CharPerSeconds;
    string targetMessage;
    int index;
    float interval;

    public GameObject EndCursor;

    Text messageText;
    AudioSource audioSource;

    public void Awake()
    {
        messageText = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }

    public void SetMessage(string message)
    {
        targetMessage = message;
        EffectStart();
    }

    void EffectStart()
    {
        messageText.text = "";
        index = 0;

        EndCursor.SetActive(false);

        interval = 0.5f / CharPerSeconds;
        Invoke("Effecting", interval);
    }

    void Effecting()
    {
        if (messageText.text == targetMessage)
        {
            EffectEnd();

            return;
        }

        messageText.text += targetMessage[index];

        if (targetMessage[index] != ' ')
        {
            audioSource.Play();
        }

        index++;

        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {
        EndCursor.SetActive(true);
    }
}
