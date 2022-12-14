using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Flyweight : MonoBehaviour
{
    [DllImport("LoadPlugin")]
    private static extern float LoadFromFile(int j, string fileName);

    [DllImport("LoadPlugin")]
    private static extern int GetLines(string fileName);

    List<Item> allItems;

    string fn;
    void Start()
    {
        allItems = new List<Item>();

        fn = Application.dataPath + "/save.txt";

        //LoadItems();
    }

   void LoadItems()
    {
        int numLines = GetLines(fn);
        int maxItems = numLines / 4;
        int infoSet = 0;

        Item newItem = new Item();
        float y = LoadFromFile(2, fn);

        for (int j = 0; j < 10000; j++)
        {
            for (int i = 0; i < maxItems; i++)
            {
                //without flyweight
                //Item newItem = new Item();

                /*newItem.itemID = (int)LoadFromFile(0 + infoSet, fn);
                newItem.itemPosition.x = LoadFromFile(1 + infoSet, fn);
                newItem.itemPosition.y = LoadFromFile(2 + infoSet, fn);
                newItem.itemPosition.z = LoadFromFile(3 + infoSet, fn);*/

                newItem.itemID = (int)LoadFromFile(0 + infoSet, fn);
                newItem.itemPosition.x = LoadFromFile(1 + infoSet, fn);
                newItem.itemPosition.y = y;
                newItem.itemPosition.z = LoadFromFile(3 + infoSet, fn);

                allItems.Add(newItem);
                infoSet += 4;
            }
            infoSet = 0;
        }
        
    }
}
