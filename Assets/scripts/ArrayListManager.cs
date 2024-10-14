using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Declare the ArrayList
    //private ArrayList itemList;
    [SerializeField]
    private List<string> itemList;

    void Start()
    {
        // Initialize the ArrayList
        // itemList = new ArrayList();
        itemList = new List<string>();



        // Adding some initial items
       // AddItem("Apple");
       // AddItem("Banana");
       // AddItem("Cherry");

        DisplayItems();
    }

    // Function to display all items in the ArrayList
    public void DisplayItems()
    {
        Debug.Log("Current items in the list:");
        foreach (string item in itemList)
        {
            Debug.Log(item);
        }
    }

    // Function to add an item to the ArrayList
    public void AddItem(string item)
    {
        itemList.Add(item);
        Debug.Log($"Added: {item}");
    }

    // Function to delete an item from the ArrayList
    public void DeleteItem(string item)
    {
        if (itemList.Contains(item))
        {
            itemList.Remove(item);
            Debug.Log($"Deleted: {item}");
        }
        else
        {
            Debug.Log($"Item not found: {item}");
        }
    }



    // Example of adding and deleting items
    void Update()
    {
        // Example usage: Press 'A' to add an item and 'D' to delete an item
       // if (Input.GetKeyDown(KeyCode.A))
        {
           // AddItem("NewItem" + Random.Range(1, 100));
           // DisplayItems();
        }

       // if (Input.GetKeyDown(KeyCode.D))
        {
           // if (itemList.Count > 0)
            {
            //    string itemToDelete = (string)itemList[0]; // Deletes the first item in the list
             //   DeleteItem(itemToDelete);
             //   DisplayItems();
            }
        }
    }

}


