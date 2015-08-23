using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalState : Singleton<GlobalState> {
    public bool PlayerCanMove = true;
	public List<string> inventory = new List<string>();

}
