using UnityEngine;
using System.Collections;

public class DialogueController : MonoBehaviour {

    private Hashtable conversations;
    [SerializeField] private GameObject textBox1;
    private TypeTextBehaviour typeText;

    // Use this for initialization
    void Start ()
    {
        typeText = textBox1.GetComponent<TypeTextBehaviour>();
        conversations = new Hashtable();
        // Load the dialogue for the scene
        // TODO below is debug ONLY
        conversations.Add("test1", new ArrayList().Add("Character\nJust testing");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void showDialogue(string id, bool freeze)
    {

    }
}
