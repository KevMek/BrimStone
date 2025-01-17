using UnityEngine;

public class Debuging : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject brickPrefab = Resources.Load<GameObject>("Prefabs/Brick");
        GameObject rockPrefab = Resources.Load<GameObject>("Prefabs/Rock");
        GameObject orePrefab = Resources.Load<GameObject>("Prefabs/Ore");


        GameObject BackgroundInventory = GameObject.Find("BackgroundInventory");
        GameObject CraftInventory = GameObject.Find("CraftInventory");
        GameObject Orders = GameObject.Find("Orders");

        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, brickPrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(CraftInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(Orders, brickPrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, brickPrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(CraftInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, brickPrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(CraftInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(CraftInventory, rockPrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, orePrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, orePrefab);
        InventoryManager.SpawnPrefabOnCanvas(BackgroundInventory, orePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
