using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TypeTextBehaviour : MonoBehaviour
{
    [SerializeField] private int ticksPerType = 5;
    private int counter = 0;
    private Text text;
    private string targetText;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private Queue stringQueue;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "";
        targetText = text.text;
        stringQueue = new Queue();
    }

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if(targetText.Length > text.text.Length)
            {
                text.text = targetText;
                AudioSource.PlayClipAtPoint(audioClip, Vector3.zero);
            }
            else
            {
                // Enqueue next string
                if(stringQueue.Count != 0)
                {
                    ProcessQueueNext();
                }
                else
                {
                    targetText = "";
                    text.text = "";
                }
            }
        }
    }

    // Fixedupdate
    void FixedUpdate()
    {
        if (targetText.Length <= text.text.Length)
        {
            GlobalState.Instance.PlayerCanMove = true;
            return;
        }

        if (counter-- == 0)
        {
            counter = ticksPerType;
            int len = text.text.Length;
            text.text += targetText.Substring(len, 1);
            AudioSource.PlayClipAtPoint(audioClip, Vector3.zero);
        }
    }

    public void SetText(string s)
    {
        targetText = s;
        text.text = "";
        counter = ticksPerType;
        
        GlobalState.Instance.PlayerCanMove = false;
    }

    public void EnqueueText(string s)
    {
        stringQueue.Enqueue(s);
    }

    public void ProcessQueueNext()
    {
        targetText = (string) stringQueue.Dequeue();
        text.text = "";
        counter = ticksPerType;

        GlobalState.Instance.PlayerCanMove = false;
    }
}

