using UnityEngine;

public class Debuging : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject brickPrefab = Resources.Load<GameObject>("Prefabs/Brick");
        GameObject rockPrefab = Resources.Load<GameObject>("Prefabs/Rock");

        GameObject BackgroundInventory = GameObject.Find("BackgroundInventory");
        GameObject CraftInventory = GameObject.Find("CraftInventory");
        GameObject Orders = GameObject.Find("Orders");

        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, brickPrefab, 0);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, rockPrefab, 1);
        InventoryManager.SpawnPrefabOnCanvas(CraftInventory, rockPrefab, 0);
        InventoryManager.SpawnPrefabOnCanvas(Orders, brickPrefab, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
