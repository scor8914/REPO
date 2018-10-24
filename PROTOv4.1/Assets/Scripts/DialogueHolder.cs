using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMAN;
    public string[] dialogLines;

	// Use this for initialization
	void Start () {
        dMAN = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                //dMAN.ShowBox(dialogue);

                if(!dMAN.dialougeActive)
                {
                    dMAN.dialogLines = dialogLines;
                    dMAN.currentLine = 0;
                    dMAN.showDialog();
                }

                if(transform.parent.GetComponent<VillagerMovement>() != null)
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }
            }
        }
    }
}
