using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnythingCounter : MonoBehaviour {

    // could refactor this to an array, but not now
    public string coinTag = "Coin";
    public string boxTag = "MysteryBox";
    public string bowlingTag = "Bowling";
    // display mode (true: anything, false: nothing)
    public bool displayIfMoreThan0;

    //private GameObject[] itemList;
    private int total;

	// Use this for initialization
	void Start () {
        GameObject[] itemList;
        total = 0;

        //ugh, this could use more polymorphism but I don't have time

        //coins first
        itemList = GameObject.FindGameObjectsWithTag(coinTag);

        // count how many were actually collected
        for (int i = 0; i < itemList.Length; i++)
        {
            if(itemList[i].GetComponent<ItemPickupTrigger>().isCollected)
            {
                total++;
            }
        }

        //boxes next
        itemList = GameObject.FindGameObjectsWithTag(boxTag);

        // count how many were actually collected
        for (int i = 0; i < itemList.Length; i++)
        {
            if (itemList[i].GetComponent<ItemPickupSquare>().isCollected)
            {
                total++;
            }
        }

        //and bowling balls
        itemList = GameObject.FindGameObjectsWithTag(bowlingTag);

        // count how many were actually collected
        for (int i = 0; i < itemList.Length; i++)
        {
            if (itemList[i].GetComponent<ItemPickupRound>().isCollected)
            {
                total++;
            }
        }

        // display this line only if the count meets display criteria
        this.GetComponent<Text>().enabled = (total > 0 == displayIfMoreThan0);
	}

	// Update is called once per frame
	void Update () {

	}
}
