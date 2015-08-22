using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwagBehaviour : MonoBehaviour
{
    private GameObject textBox;
    private TypeTextBehaviour typeText;
    public string dialogue;

    private bool activated = false;

    // Use this for initialization
    void Start()
    {
        textBox = GameObject.Find("Text");
        typeText = textBox.GetComponent<TypeTextBehaviour>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D yay)
    {
        if (activated || !yay.gameObject.tag.Equals("Player")) return;
        typeText.SetText("Swag the yolo at dawn");

        activated = true;
    }


}

