using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorListing : MonoBehaviour {

	public List<GameObject> doorList;

	// Use this for initialization
	void Start () {
		UpdateList();
	}
	
	public void UpdateList(){
		foreach(GameObject door in GameObject.FindGameObjectsWithTag ("Door")){
			doorList.Add(door);
		}
	}

	void ShapeChanged(){
		UpdateList();
	}
}
