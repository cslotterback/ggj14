using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
		public Shape currentShape = Shape.Cube;
		public float enemySpeed = 5f;
		public int enemyDamage = 1;
		public List<GameObject> shapeList;
		public float maxCooldownTime = 2;
		private float currentCooldownTime = 0;
		public float hitDistance = 1.3f;

		// Use this for initialization
		void Start ()
		{
				if (shapeList != null)
						shapeList [(int)currentShape].SetActive (true);
				else
						Debug.Log ("Add Shapes to Enemy ShapeList!");
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (currentCooldownTime > 0) {
						currentCooldownTime -= Time.deltaTime;
				}

		}

		void OnTriggerStay (Collider other)
		{
				if (other.gameObject.GetComponentInChildren<PlayerSwitch> () != null) {
						if (other.gameObject.GetComponentInChildren<PlayerSwitch> ().currentShape != currentShape) {
								MoveTowards (other.transform.position + Vector3.up);
						}
				} else if (other.gameObject.GetComponent<Enemy> () != null) {
						if (other.gameObject.GetComponent<Enemy> ().currentShape != currentShape) {
								MoveTowards (other.transform.position);
						}
				}

				if ((other.tag == "Player" || other.tag == "Enemy") && currentCooldownTime <= 0 && Vector3.Distance (transform.position, other.transform.position) < hitDistance) {
						other.GetComponent<Health> ().TakeDamage (enemyDamage);
						currentCooldownTime = maxCooldownTime;
				}


		}

		void MoveTowards (Vector3 targetPosition)
		{

				transform.LookAt (targetPosition, Vector3.up);
				if (Vector3.Distance (transform.position, targetPosition) > hitDistance)
						transform.Translate (0, 0, enemySpeed * Time.deltaTime);
		}

		public void OnPlayerSwitch ()
		{
				float randomValue = Random.value * 10;
				if (randomValue > 5) {
						shapeList [(int)currentShape].SetActive (false);
						currentShape = (Shape)Random.Range (0, shapeList.Count - 1);
						shapeList [(int)currentShape].SetActive (true);
				}
			
		}
}
