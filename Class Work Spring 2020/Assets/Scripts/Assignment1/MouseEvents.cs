using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDown, mouseHover, mouseDrag, mouseEnter, mouseExit, mouseUp, mouseUpButton;

    private void OnMouseDown()
    {
        mouseDown.Invoke();
    }

    private void OnMouseOver()
    {
        mouseHover.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDrag.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnter.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExit.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUp.Invoke();
    }

    private void OnMouseUpAsButton()
    {
        mouseUpButton.Invoke();
    }
}
