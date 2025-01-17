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
            Instantiate(prefab, slot.transform);
            return true;
        }
        return false;

    }

    public static void DeletePrefabOnCanvas(GameObject canvas, int index)
    {
        Transform slot = canvas.transform.GetChild(0).transform.GetChild(index);
        Destroy(slot);
    }
}
