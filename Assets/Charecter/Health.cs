using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	[Range(0,100)] public int health;

	void Awake () {
	}
	
	void Update () {
		
	}

	public void decreaseHealth(int a){
		health -= a; 
	}

	public int getHealth(){
		return health;
	}
}
