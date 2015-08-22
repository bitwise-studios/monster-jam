using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TypeTextBehaviour : MonoBehaviour
{

    public int ticksPerType = 5;
    private int counter = 0;
    private Text text;
    private string targetText;
    public AudioClip audioClip;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        targetText = text.text;
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

