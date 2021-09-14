using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory instance;
    public List<item> items = new List<item>();
    private void Awake()
    {
        instance = this;
    }
 


   public void addItem(item item)
    {
        items.Add(item);
    }
    public void removeItem(item item)
    {
        items.Remove(item);
    }
}
