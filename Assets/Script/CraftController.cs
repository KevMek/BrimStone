using System;
using UnityEngine;
using UnityEngine.UI;

public class CraftController : MonoBehaviour
{
    
    public Button craftButton;
    int materialAmount = 3;

    private void Start()
    {
        int[] contents = new int[materialAmount] ; 
        GameObject CraftInventory = GameObject.Find("CraftInventory");
        
        craftButton.onClick.AddListener(() => InventoryManager.ReadInventory(CraftInventory, contents));
        craftButton.onClick.AddListener(() => Recipe.Craft(contents));



    }
}
