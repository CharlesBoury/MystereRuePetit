using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurnCamera : MonoBehaviour, IDragHandler, IEndDragHandler
{
	public Transform pivot;
	public float sensitivity = 0.4f;
	public float friction = 0.01f;

	float acceleration = 0;
	float rotation = 0;

	Vector2 mouseReference;
	Vector2 mouseOffset;
 
    void Update()
    {
    	rotation += acceleration;
    	rotation *= friction;

    	pivot.Rotate(new Vector3(0, rotation, 0));

    	mouseReference = Input.mousePosition;
    }

    public void OnDrag(PointerEventData pointerEventData)
    {
		mouseOffset = (pointerEventData.position - mouseReference);
		acceleration = mouseOffset.x * sensitivity;
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
    	acceleration = 0;
    }
}
