using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    public bool dialougeActive;

    public string[] dialogLines;
    public int currentLine;

    private PlayerController thePlayer;

  	// Use this for initialization
	void Start () {
        dBox.SetActive(false);
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (dialougeActive && Input.GetKeyUp(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialougeActive = false;

            currentLine++;
        }

        if(currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialougeActive = false;

            currentLine = 0;
            thePlayer.canMove = true;
        }

        dText.text = dialogLines[currentLine];
    }

    public void ShowBox(string dialogue)
    {
        dialougeActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void showDialog()
    {
        dialougeActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }

}
