using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{

		void OnTriggerEnter (Collider other)
		{
				BoxCollider collider = gameObject.GetComponent ("Box Collider") as BoxCollider;
				if (collider != null)
						collider.enabled = false;
		}
}
