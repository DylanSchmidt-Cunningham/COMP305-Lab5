using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlingAllNothing : MonoBehaviour {

    public string itemTag = "Bowling";

    private GameObject[] itemList;
    private int total;

	// Use this for initialization
	void Start () {
        itemList = GameObject.FindGameObjectsWithTag(itemTag);
        total = 0;

        // count how many were actually collected
        for(int i = 0; i < itemList.Length; i++)
        {
            if(itemList[i].GetComponent<ItemPickupRound>().isCollected)
            {
                total++;
            }
        }

        // display this image only if the player collected anything
        GetComponent<Image>().enabled = total > 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
