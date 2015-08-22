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

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "";
        targetText = text.text;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(targetText.Length > text.text.Length)
            {
                text.text = targetText;
                AudioSource.PlayClipAtPoint(audioClip, Vector3.zero);
            }
            else
            {
                targetText = "";
                text.text = "";
            }
        }
    }

    // Fixedupdate
    void FixedUpdate()
    {
        if (targetText.Length <= text.text.Length)
        {
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
    }


}

