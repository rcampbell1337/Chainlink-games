using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed = 0.00001f;

    public GameObject continueButton;
    Animator animator;

    void Start()
    {
        StartCoroutine(Type());
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            animator.enabled = true;
        }
    }

    IEnumerator Type()
    {
       foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        animator.enabled = false;
        if (index < sentences.Length - 1)
        {
            index += 1;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
