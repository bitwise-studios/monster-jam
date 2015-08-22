using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwagBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject textBox;
    private TypeTextBehaviour typeText;
    [SerializeField] private string dialogue;

    private bool activated = false;

    // Use this for initialization
    void Start()
    {
        typeText = textBox.GetComponent<TypeTextBehaviour>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D yay)
    {
        if (activated || !yay.gameObject.tag.Equals("Player")) return;
        typeText.SetText(dialogue);

        activated = true;
    }


}

