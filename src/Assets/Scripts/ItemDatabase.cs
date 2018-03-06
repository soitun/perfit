﻿using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
	public List<ClothingItem> clothesList = new List<ClothingItem>();
    public static ItemDatabase instance; 


    private void Awake()
    {
        //create singleton
        instance = this; 

		//1.Naked (Empty/No dress/0)
		clothesList.Add(new ClothingItem(0, "", "", "naked", "Dress"));

		//2.Dresses
									//ItemID //Name //Description //FileName //ItemType //GameObjectInstance

		clothesList.Add(new ClothingItem(1, "", "", "dress01", "Dress", (GameObject)Resources.Load("Dresses/small/dress01")));
		clothesList.Add(new ClothingItem(2, "", "", "dress02", "Dress", (GameObject)Resources.Load("Dresses/small/dress02")));
		clothesList.Add(new ClothingItem(3, "", "", "dress03", "Dress", (GameObject)Resources.Load("Dresses/small/dress03")));
		clothesList.Add(new ClothingItem(4, "", "", "dress04", "Dress", (GameObject)Resources.Load("Dresses/small/dress04")));
		clothesList.Add(new ClothingItem(5, "", "", "underwear01", "Dress", (GameObject)Resources.Load("Dresses/underwear01")));

	}

	public ClothingItem FetchItemByID(int id)
    {
		for (int i = 0; i < clothesList.Count; i++)
        {
			if (clothesList[i].ItemID == id)
            {
				return clothesList[i];
            }
        }
        return null;
    }

	public ClothingItem FetchItemByFileName(string file)
    {
		for (int i = 0; i < clothesList.Count; i++)
        {

			if (clothesList[i].FileName == file)
            {
				return clothesList[i];
            }
        }
        return null;
    }


}
