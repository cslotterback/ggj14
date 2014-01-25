using UnityEngine;
using System.Collections;

public class TextBehavior : MonoBehaviour {

	[SerializeField] private bool isQuit = false;
	[SerializeField] private bool isTest = false;

	void Start(){

	}

	void OnMouseEnter(){
		Debug.Log ("text entered");
		renderer.material.color = Color.grey;

	}

	void OnMouseExit(){
		Debug.Log ("text exited");
		renderer.material.color = Color.white;

	}

	void OnMouseUp(){
		Debug.Log ("text clicked");
		if (isQuit == true) {
			Application.Quit ();
		} else if (isTest == true) {
			Application.LoadLevel ("TestLevel");
			Debug.Log ("load tester");
		} else {
			Application.LoadLevel ("TestLevel");
		}
	}
}
