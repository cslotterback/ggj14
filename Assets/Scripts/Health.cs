using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
		public int maxHealth = 10;
		private int currentHealth;

		void Start ()
		{
				currentHealth = maxHealth;
		}

		public void TakeDamage (int damage)
		{
				currentHealth -= damage;

				if (currentHealth < 0) {
				
						currentHealth = 0;
						Die ();
				}

		}

		private void Die ()
		{
				Destroy (gameObject);
		}
}
