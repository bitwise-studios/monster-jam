using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewspaperSetHeadlineBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = GlobalState.Instance.newspaperHeadline;
	}

}
