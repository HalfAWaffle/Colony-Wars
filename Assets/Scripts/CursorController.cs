using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour {

	private Vector3 gridLoc; 
	private GameObject target; 

	void Update () {
		if (Input.GetMouseButton(0)) {
			Vector3 mousePos; 
			Vector3 mousePosToWorldSpace;
			mousePos = Input.mousePosition;
			mousePosToWorldSpace = Camera.main.ScreenToWorldPoint (mousePos);
			float x = Mathf.Round (mousePosToWorldSpace.x); 
			float y = Mathf.Round (mousePosToWorldSpace.y); 
			float z = Mathf.Round (mousePosToWorldSpace.z); 
			gridLoc = new Vector3 (x, y, z);
		}
		if (target) {
		}

	}

	public Vector3 getMousePos(){
		return gridLoc;

	}

	public void getGameObject(GameObject a){
		target = a; 
	}

	public GameObject getTarget(){
		return target;
	}

}
