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
            bool successefulSwap = false;
            if (parent.name == "BackgroundInventory")
            {
                GameObject CraftInventory = GameObject.Find("CraftInventory");
                successefulSwap = InventoryManager.SpawnPrefabOnCanvas(CraftInventory, gameObject);

            }
            else if (parent.name == "CraftInventory")
            {
                GameObject BackgroundInventory = GameObject.Find("BackgroundInventory");
                successefulSwap = InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, gameObject);
            }
            
           if (successefulSwap)
            {
                Destroy(gameObject);
            }
           
           
        }
    }
}
