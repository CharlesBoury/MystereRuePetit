using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Renderer))]
public class HideOnClick : MonoBehaviour, IPointerClickHandler
{
	Renderer myRenderer;

	public void Start()
	{
		myRenderer = gameObject.GetComponent<Renderer>();
	}

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        myRenderer.enabled = !myRenderer.enabled;
    }
}
