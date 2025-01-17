using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            Destroy(gameObject);
        }
        else if (eventData.button == PointerEventData.InputButton.Left)
        {
            
            Transform parent = transform.parent.parent.parent;
            if (parent.name == "BackgroundInventory")
            {
                GameObject CraftInventory = GameObject.Find("CraftInventory");
                InventoryManager.SpawnPrefabOnCanvas(CraftInventory, gameObject, 0);
            }
            else if (parent.name == "CraftInventory")
            {
                GameObject BackgroundInventory = GameObject.Find("BackgroundInventory");
                InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, gameObject, 0);
            }
            
           Destroy(gameObject);
        }
    }
}
