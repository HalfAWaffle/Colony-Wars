using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestScript : MonoBehaviour
{

	private NavMeshAgent NVA;
	private CursorController cursor;
	public GameObject myTestDummy;
	public GameObject redCircle;
	public GameObject bullet;

	public GameObject fuck;
	   

	void Start ()
	{
		NVA = this.GetComponent<NavMeshAgent> ();
		cursor = GameObject.FindObjectOfType<CursorController> ();
		NVA.updateRotation = false;
		NVA.SetDestination (this.transform.position);
	}

	void Update ()
	{
		updateDestination ();


	}

	private void updateDestination(){
		if (cursor.getTarget () == myTestDummy) {
			if (cursor) {
				Vector3 mousePos = cursor.getMousePos ();
				Vector3 circlePos = new Vector3 (mousePos.x, 1.1f, mousePos.z);
				mousePos.y = this.transform.position.y;
				Instantiate (redCircle, circlePos, fuck.transform.rotation);
				NVA.SetDestination (mousePos);
			}
		}
		// i dont know what this used to do, im assuming nothing
		//this.transform.position.Set (this.transform.position.x, 0f, this.transform.position.z);
	}

	private void fire(){
	}
		

}
