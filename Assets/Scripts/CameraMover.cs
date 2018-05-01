using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	// Use this for initialization
	[Range(1f,10f)] public float panSpeed;

	public Canvas gameSpaceCanvas;
	private RectTransform gameSpaceRectTransform;
	private Camera thisCam; 

	private float leftSide;
	private float rightSide; 
	private float cameraWidth;
	private float gameSpaceWidth;

	void Start () {
		findEdges ();
	}
	
	// Update is called once per frame
	void Update () {
		moveCamera ();
		ClampEdges ();
	}


	private void moveCamera(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (new Vector3 (panSpeed * Time.deltaTime, 0f, 0f));
			//print ("right");
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (new Vector3 (-1f * Time.deltaTime * panSpeed, 0f, 0f));
			//print ("left");
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (new Vector3 (0f, Time.deltaTime * panSpeed, 0f));
			//print ("Up");
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (new Vector3 (0f, Time.deltaTime * panSpeed * -1f, 0f));
			//print ("Down");

	}
	}

	private void ClampEdges(){
		float edges = Mathf.Clamp (this.transform.position.x, -1* gameSpaceWidth/2+cameraWidth, gameSpaceWidth/2-cameraWidth);
		this.transform.position = new Vector3 (edges, this.transform.position.y, this.transform.position.z);
	}

	private void findEdges(){
		gameSpaceRectTransform = gameSpaceCanvas.GetComponent<RectTransform> ();
		thisCam = this.GetComponent<Camera> ();
		cameraWidth = thisCam.orthographicSize; 
		gameSpaceWidth = gameSpaceRectTransform.rect.width;
	}

}
