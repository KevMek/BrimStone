using JetBrains.Annotations;
using System;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public static int FindAvaliableSlot(GameObject canvas)
    {
        int index = 0;
        Transform inventory = canvas.transform.GetChild(0);
        int childCount = inventory.childCount;
        for (int i = 0; i < childCount; i++)
        {
           if(inventory.transform.GetChild(i).childCount != 0 )
            {
                index++;
                
            }
           else
            {
                return index;
            }

        }



        return -1;
    }
    public static bool SpawnPrefabOnCanvas(GameObject canvas, GameObject prefab)
    {
        int index = FindAvaliableSlot(canvas);
        if (index != -1)
        {
            Transform slot = canvas.transform.GetChild(0).transform.GetChild(index);
            GameObject instantiatedObj = Instantiate(prefab, slot.transform);
            instantiatedObj.name = prefab.name;
            return true;
        }
        return false;

    }

    public static void DeletePrefabOnCanvas(GameObject canvas, int index)
    {
        Transform slot = canvas.transform.GetChild(0).transform.GetChild(index);
        Destroy(slot);
    }

    public static void ReadInventory(GameObject canvas, int[] content)
    {
        for (int k = 0; k < content.Length; k++)
        {
            content[k] = 0;
        }
        
        if (canvas.transform.childCount == 0)
        {
            
            return;
        }
        Transform inventory = canvas.transform.GetChild(0);
        int totalSlot = inventory.childCount;
        for (int i = 0; i < totalSlot; i++)
        {
            if (inventory.transform.GetChild(i).childCount == 0)
            {
                
                continue;
            }
            Transform item = inventory.transform.GetChild(i).GetChild(0);
            if (!item)
            {
                continue;
            }
            switch (item.name)
            {
                case "Rock":
                    content[0]++;
                    break;

                case "Brick":
                    content[1]++;
                    break;

                case "Iron":
                    content[2]++;
                    break;

                case "Silver":
                    content[3]++;
                    break;

                case "Gold":
                    content[4]++;
                    break;

                case "Diamond":
                    content[5]++;
                    break;

                default:
                    break;
            }
            
        }
        
        
        Debug.Log($"item {0} : {content[0]}");
        Debug.Log($"item {1} : {content[1]}");
        Debug.Log($"item {2} : {content[2]}");
    }
}
