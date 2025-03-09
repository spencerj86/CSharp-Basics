﻿//=============================================================================
// Program's Inventory class
//=============================================================================

using System;

namespace Shop
{
    public class Inventory
    {
        // TODO: Define three member fields
        //       An int called mMaxSize
        //       An array of Items called mItems
        //       An int called mGold
        int mMaxSize;
        Item[] mItems;
        int mGold;


        // TODO: Write a default constructor that assigns the mMaxSize to 10,
        //       mItems to a new array of Items with mMaxSize as the size,
        //       and mGold to 50.
        public Inventory()
        {
            mMaxSize = 10;
            mItems = new Item[mMaxSize];
            mGold = 50;
        }


        // TODO: Write a C# property for mGold called Gold (it has to
        //       access/update the mGold member field).
        public int Gold
        {
            get { return mGold; }
            set { mGold = value; }
        }

        // TODO: Write a method called AddItem that returns a bool and takes an Item parameter.
        //       This method should iterate through the mItems array, looking for any array element
        //       that is null. If a null Item is found, it should assign that array element to the
        //       Item passed in and return true. Otherwise it should return false.
        public bool AddItem(Item add)
        {
            bool test = false;
            for(int i = 0; i < mItems.Length; i++)
            {
                if(mItems[i] == null)
                {
                    mItems[i] = add;
                    test = true;
                    break;
                }
            }
            return test;
        }

        // TODO: Write a method called RemoveItem that returns a bool and takes a string parameter.
        //       This method should iterate through the mItems array, looking for an Item that
        //       has the same name as the parameter. If it finds a match it should set that 
        //       element of the mItems array to null and return true. Otherwise return false.
        //       Do not forget to make sure the element is not null before checking its name.
        public bool RemoveItem(string remove)
        {
            bool test = true;
            for (int i = 0; i < mItems.Length; i++)
            {
                if (mItems[i] != null && mItems[i].GetName() == remove)
                {
                    mItems[i] = null;
                    test = false;
                    break;
                }
            }
            return test;
        }

        // TODO: Write a method called GetItem that returns an Item and takes a string parameter.
        //       This method should iterate through the mItems array, looking for an Item that
        //       has the same name as the parameter. If it finds a match it should return that element 
        //       of the mItems array. Otherwise return null.
        //       Do not forget to make sure the element is not null before checking its name.
        public Item GetItem(string select)
        {
            Item s1 = null;
            for(int i = 0; i < mItems.Length; i++)
            {
                
                if(mItems[i] != null && mItems[i].GetName() == select)
                {
                    s1 = mItems[i];
                    break;
                }
                //if(mItems[i] == null)
                //{
                //    s1 = null;
                //}
            }
            return s1;
        }

        // TODO: Uncomment the following code:

        public void DisplayInventory(int x, int y)
        {
            Console.SetCursorPosition(x, ++y);
            Console.Write("Item Name");
            Console.SetCursorPosition(x + 17, y);
            Console.Write("Item Cost");

            for (int i = 0; i < mMaxSize; i++)
            {
                if (null != mItems[i])
                {
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(mItems[i].GetName());
                    Console.SetCursorPosition(x + 17, y);
                    Console.Write(mItems[i].GetCost());
                }
            }

            y += 2;
            Console.SetCursorPosition(x, ++y);
            Console.Write("Gold on hand:");
            Console.SetCursorPosition(x + 17, y);
            Console.Write(Gold);
        }

    }
}
