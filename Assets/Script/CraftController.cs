using System;
using UnityEngine;
using UnityEngine.UI;

public class CraftController : MonoBehaviour
{
    
    public Button craftButton;

    private void Start()
    {
        int[] contents = new int[3] ; 
        GameObject CraftInventory = GameObject.Find("CraftInventory");
        
        craftButton.onClick.AddListener(() => InventoryManager.ReadInventory(CraftInventory, contents));

        foreach (int items in contents)
        {
            Debug.Log($"items : {items}");
        }
        
    }
}
