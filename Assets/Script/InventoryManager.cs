using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static void SpawnPrefabOnCanvas(GameObject canvas, GameObject prefab, int index)
    {
        Transform slot = canvas.transform.GetChild(0).transform.GetChild(index);
        GameObject instantiatedPrefab = Instantiate(prefab, slot.transform);
    }
}
