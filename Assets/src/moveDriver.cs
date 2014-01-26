using UnityEngine;
using System.Collections;

public class moveDriver : MonoBehaviour
{
		public float speed = 0.5f;
		public float rotationSpeed = 5f;
		// Use this for initialization
		void Start ()
		{
		}

		// Update is called once per frame
		void Update ()
		{
				float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
				float rotation = Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
				transform.Translate (0, 0, translation);
				transform.Rotate (0, rotation, 0);
		}
}
