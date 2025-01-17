using System;
using UnityEngine;
using System.Linq;

public class Recipe : MonoBehaviour
{
    [SerializeField] GameObject craftInventory;
    

    /*
     * 0 Rock
     * 1 Brick
     * 2 Ore
    */

    public static int[] recipeGrenade = { 0, 3, 0 };
    public static int[] recipePistol = { 1, 0, 2 };
    public static int[] recipeShotGun = { 2, 1, 1 };
    public static int[] recipeClub = { 1, 1, 2 };

    public static void Craft(int[] contents)
    {
        GameObject pistolPrefab = Resources.Load<GameObject>("Prefabs/Pistol");
        GameObject grenadePrefab = Resources.Load<GameObject>("Prefabs/Grenade");
        GameObject clubPrefab = Resources.Load<GameObject>("Prefabs/Club");
        GameObject shotGunPrefab = Resources.Load<GameObject>("Prefabs/ShotGun");
        //Debug.Log($"item 1: {contents[0]}");
        //Debug.Log($"item 2: {contents[1]}");
        //Debug.Log($"item 3: {contents[2]}");
        if (contents.SequenceEqual(recipeGrenade)) CrafItem(grenadePrefab);
        if (contents.SequenceEqual(recipePistol)) CrafItem(pistolPrefab);
        if (contents.SequenceEqual(recipeShotGun)) CrafItem(shotGunPrefab);
        if (contents.SequenceEqual(recipeClub)) CrafItem(clubPrefab);

    }

    public static void CrafItem(GameObject item)
    {
        GameObject output = GameObject.Find("Output");
        Debug.Log("Recipe completed");
        InventoryManager.SpawnPrefabOnCanvas(output, item);
    }


}
