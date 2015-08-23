using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueActivateBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject dialogueControllerObject;
    [SerializeField] private string dialogueId = "";
    [SerializeField] private bool activateOnce = true;
    [SerializeField] private bool freezeOnTrigger = false;

    private DialogueController controller;
    
    private bool activated = false;

    // Use this for initialization
    void Start()
    {
        if (dialogueControllerObject == null)
            dialogueControllerObject = GameObject.Find("DialogueController");
        controller = dialogueControllerObject.GetComponent<DialogueController>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!isActiveAndEnabled) return;
        if ((activated && activateOnce) || !collider.gameObject.tag.Equals("Player")) return;
        
        typeText.SetText(dialogue);
        activated = true;
        if (freezeOnTrigger)
        {
            GlobalState.Instance.PlayerCanMove = false;
        }
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D yay)
    {
        if (!isActiveAndEnabled) return;
        if ((activated && activateOnce) || !yay.gameObject.tag.Equals("Player")) return;
        typeText.SetText(dialogue);

        activated = true;
    }


}

