using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static void SpawnPrefabOnCanvas(GameObject canvas, GameObject prefab, int index)
    {
        Transform slot = canvas.transform.GetChild(0).transform.GetChild(index);
        Instantiate(prefab, slot.transform);
    }

    public static void DeletePrefabOnCanvas(GameObject canvas, int index)
    {
        Transform slot = canvas.transform.GetChild(0).transform.GetChild(index);
        Destroy(slot);
    }
}
