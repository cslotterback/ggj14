using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{

		private Transform myTransform;
		private Transform targetToLookAt;
		public float distance = 5f;
		public float height = 2;
		public float rotationSpeed = 1;

		// Use this for initialization
		void Start ()
		{
				Screen.lockCursor = true;
				myTransform = transform;
				targetToLookAt = myTransform.root;		
				myTransform.position = new Vector3 (targetToLookAt.position.x, targetToLookAt.position.y + height, targetToLookAt.position.z - distance);
		}
	
		// Update is called once per frame
		void Update ()
		{
				myTransform.LookAt (targetToLookAt);
				if (Input.GetAxis ("Mouse X") != 0) {
						myTransform.RotateAround (targetToLookAt.position, Vector3.up, Input.GetAxis ("Mouse X") * rotationSpeed * Time.deltaTime);
				}
		}
}
