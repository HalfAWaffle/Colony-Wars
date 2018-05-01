using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {

	public Text healthText; 
	private Health healthComponent;
	private CursorController cc;
	private GameObject target;

	void Start () {
		cc = GameObject.FindObjectOfType<CursorController> ();
	}
	
	void Update () {
		target = cc.getTarget ();
		if (target) {
			healthComponent = target.GetComponent<Health> ();
			int healthCount;
			healthCount = healthComponent.getHealth();
			healthText.text = healthCount.ToString ();
		}

	}
}
