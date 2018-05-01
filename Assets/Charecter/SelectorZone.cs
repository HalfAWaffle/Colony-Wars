using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorZone : MonoBehaviour {

	private CursorController cc;
	public GameObject myTestDummy;
	// Use this for initialization
	void Start () {
		cc = GameObject.FindObjectOfType<CursorController> ();
	}

	public void Operate(){
		cc.getGameObject (myTestDummy);
	}

}
