using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{

		[SerializeField]
		Shape
				_doorShape;
		public Material solidMaterial;
		public Material transparentMaterial;

		// Update is called once per frame
		public Shape doorShape {
				get {
						return _doorShape;
				}

				set {
						_doorShape = value;
				}
		}

		void OnTriggerEnter (Collider other)
		{
				if (other.gameObject.tag == "Player") {
						if (other.GetComponent<PlayerSwitch> ().currentShape == doorShape) {
								this.collider.enabled = false;
								renderer.material = transparentMaterial;
						} else {
								this.collider.enabled = true;
								renderer.material = solidMaterial;
						}
					
				}
		}
}
