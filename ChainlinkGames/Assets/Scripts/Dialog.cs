using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// A class for displaying story text
public class Dialog : MonoBehaviour
{

    /* All of the public variables: 
     textDisplay: Where the sentences are applied to
     sentences: refers to the text for display
     typingSpeed: refers to how fast the text is displayed
     continueButton: is pressed to open the next dialog line
     game: represents the gameplay which is displayed after all dialog options have been revealed
     */
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed = 0.00001f;
    public GameObject continueButton;
    public GameObject game;

    /*
     All of the private variables:
    parentForClose: Text display canvas is closed from here
    animator: enables and disables animations
    private: get Players rigidbody
    index: an integer which tracks the number of sentences shown
     */
    private GameObject parentForClose;
    private GameObject player;
    private Rigidbody2D rb;
    private Animator animator;
    private int index;

    // Define some variables to start and begin the first sentence typing
    void Start()
    {
        StartCoroutine(Type());
        animator = gameObject.GetComponent<Animator>();
        textDisplay = gameObject.GetComponent<TextMeshProUGUI>();
        parentForClose = transform.parent.gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Checks to see if the continue option is allowed when a sentence is completed
    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            animator.enabled = true;
            if (Input.GetButtonDown("Jump"))
            {
                NextSentence();
            }
        }
    }

    // Displays each letter of the sentence
    IEnumerator Type()
    {
       foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    // Shows the next sentence and checks to see if all sentences are complete
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
            game.SetActive(true);
            parentForClose.SetActive(false);
            rb.gravityScale = 2.5f;
            JumpScript.jumpHeight = 200;
            player.SetActive(true);
        }
    }
}
