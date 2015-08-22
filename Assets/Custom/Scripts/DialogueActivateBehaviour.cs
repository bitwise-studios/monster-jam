using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueActivateBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject textBox;
    private TypeTextBehaviour typeText;
    [SerializeField] private string dialogue = "";
    [SerializeField] private bool activateOnce = true;
    [SerializeField] private bool freezeOnTrigger = false;
    
    private bool activated = false;

    // Use this for initialization
    void Start()
    {
        typeText = textBox.GetComponent<TypeTextBehaviour>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if((activated && activateOnce) || !collider.gameObject.tag.Equals("Player")) return;
        typeText.SetText(dialogue);
        activated = true;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D yay)
    {
        if ((activated && activateOnce) || !yay.gameObject.tag.Equals("Player")) return;
        typeText.SetText(dialogue);

        activated = true;
    }


}

