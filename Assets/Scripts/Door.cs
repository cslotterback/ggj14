using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	[SerializeField]
	Shape _doorShape;

	// Update is called once per frame
	public Shape doorShape{
		get{
			return _doorShape;
		}

		set{
			_doorShape = value;
		}
	}	
}
