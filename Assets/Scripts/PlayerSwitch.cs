using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSwitch : MonoBehaviour
{
	public List<GameObject> shapeList;
	public Shape currentShape = Shape.Cube;
	private int inputInt;
	private float mouseScrollWheel;
	
	void Start ()
	{
		foreach (GameObject g in shapeList) {
			g.SetActive (false);		
		}
		shapeList [(int)currentShape].SetActive (true);
	}
	
	void Update ()
	{
		mouseScrollWheel = Input.GetAxis ("Mouse ScrollWheel");
		if (mouseScrollWheel != 0 || int.TryParse (Input.inputString, out inputInt))
			ChangeShape ();
		
	}
	
	void ChangeShape ()
	{
		int shapeIndex = (int)currentShape;
		shapeList [shapeIndex].SetActive (false);
		if (inputInt != 0 && inputInt <= shapeList.Count)
			shapeIndex = inputInt - 1;
		else if (mouseScrollWheel != 0) {
			
			if (mouseScrollWheel > 0)
				shapeIndex ++;
			else if (mouseScrollWheel < 0)
				shapeIndex--;
			
			if (shapeIndex > shapeList.Count - 1)
				shapeIndex = 0;
			else if (shapeIndex < 0)
				shapeIndex = shapeList.Count - 1;
		}
		
		shapeList [shapeIndex].SetActive (true);
		currentShape = (Shape)shapeIndex;
	}
}
