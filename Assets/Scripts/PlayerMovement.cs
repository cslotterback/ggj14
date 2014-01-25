using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
		public float speed = 10f;
		public float rotationSpeed = 90f;
		public float jumpStrength = 1;
		private CharacterController cc;
		private float verticalVelocity;
		private Transform myTransform;

		// Use this for initialization
		void Start ()
		{
				myTransform = transform;
				cc.GetComponent<CharacterController> ();
		}

		// Update is called once per frame
		void Update ()
		{
				Movement ();
			

		}

		void Movement ()
		{
				Vector3 dist;
				if (Input.GetButtonDown ("Jump") && cc.isGrounded)	
						verticalVelocity = jumpStrength;
				else if (Input.GetButtonUp ("Jump") && !cc.isGrounded && verticalVelocity < 0)
						verticalVelocity = 0;
		
				float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
				float rotation = Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
				
				cc.Move (new Vector3 ());
				myTransform.Rotate (0, rotation, 0);
		}
}
