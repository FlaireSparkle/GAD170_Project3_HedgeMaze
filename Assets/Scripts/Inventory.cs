using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    public List<Item> myInventory = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        myInventory.Clear();
    }

    /// <summary>
    /// add this item to this inventory
    /// </summary>
    /// <param name="itemID"></param>
    public void PickupItem(int itemID)
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
