using UnityEngine;
using System.Collections;

public class DialogueController : MonoBehaviour {

    private Hashtable conversations;
    [SerializeField] private GameObject textBox1;
    private TypeTextBehaviour typeText1;

    private bool textBox1Done = true;

    private ArrayList currentDialogue;

    // Use this for initialization
    void Start ()
    {
        typeText1 = textBox1.GetComponentInChildren<TypeTextBehaviour>();
        conversations = new Hashtable();
        // Load the dialogue for the scene
        // TODO below is debug ONLY
        ArrayList testList = new ArrayList();
        testList.Add("Character\nJust testing");
        conversations.Add("test1", testList);
    }
	
	// Update is called once per frame
	void Update () {
        if (textBox1Done)
        {
            GlobalState.Instance.PlayerCanMove = true;
        }
	}

    public void showDialogue(string id, bool freeze)
    {
        if (freeze)
            GlobalState.Instance.PlayerCanMove = false;
        textBox1Done = false;
        currentDialogue = (ArrayList) conversations[id];
        foreach(string item in currentDialogue)
        {
            typeText1.EnqueueText(item);
        }
        typeText1.ProcessQueueNext();
    }

    public void showDialogueComplete(TypeTextBehaviour typeText)
    {
        if(typeText1 == typeText)
        {
            textBox1Done = true;
        }
    }
}
