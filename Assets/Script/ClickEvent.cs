using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left mouse button clicked!");
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right mouse button clicked!");
        }
    }
}
