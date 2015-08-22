using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwagBehaviour : MonoBehaviour
{
    public GameObject textBox;

    private bool activated = false;

    // Use this for initialization
    void Start()
    {
        textBox = GameObject.Find("Text");
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D yay)
    {
        if (activated || !yay.gameObject.tag.Equals("Player")) return;
        textBox.GetComponent<Text>().text = "SWAGBLAZE";

        activated = true;
    }
}

