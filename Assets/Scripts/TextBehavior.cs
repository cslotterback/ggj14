using UnityEngine;
using System.Collections;

public class TextBehavior : MonoBehaviour {

	[SerializeField]
	private bool isQuit = false;

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
		} else {
			Application.LoadLevel ("TestLevel");
		}
	}
}
