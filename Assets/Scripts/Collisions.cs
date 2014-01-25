using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		Debug.Log("collision with" + collision.transform.name);
	}

	void OnCollisionExit(Collision collisionInfo) {
		Debug.Log("No longer in contact with " + collisionInfo.transform.name);
	}
}
