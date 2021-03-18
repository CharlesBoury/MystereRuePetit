using System.Collections;
using UnityEngine;
// using UnityEngine.EventSystems;

public class TurnWithMouse : MonoBehaviour
{
	public Transform pivot;
	public float sensitivity = 10f;
	public float friction = 0.9f;

	float acceleration = 0;
	float rotation = 0;

	Vector3 mouseReference;
	Vector3 mouseOffset;
 
    void LateUpdate()
    {

    	if (Input.GetMouseButton(0))
    	{
			mouseOffset = Input.mousePosition - mouseReference;
			acceleration = mouseOffset.x / Screen.width * sensitivity;
    	}
    	else
    	{
    		acceleration = 0;
    	}

    	rotation += acceleration;
    	rotation *= friction;

    	pivot.Rotate(new Vector3(0, rotation, 0));

    	mouseReference = Input.mousePosition;
    }
}
