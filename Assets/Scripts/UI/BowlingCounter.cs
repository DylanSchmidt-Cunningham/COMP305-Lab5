using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlingCounter : MonoBehaviour {

    public string itemTag = "Bowling";
    public int frameDelay = 1;

    private GameObject[] itemList;
    private int total;
    private int displayedCount;
    private int frameCount;
    private Text display;

	// Use this for initialization
	void Start () {
        itemList = GameObject.FindGameObjectsWithTag(itemTag);
        displayedCount = 0;
        total = 0;
        frameCount = 0;
        display = this.GetComponent<Text>();

        // count how many were actually collected
        for(int i = 0; i < itemList.Length; i++)
        {
            if(itemList[i].GetComponent<ItemPickupRound>().isCollected)
            {
                total++;
            }
        }

        // display this text only if the player collected anything
        display.enabled = total > 0;
    }
	
	// Update is called once per frame
	void Update () {
        // increment the number of items displayed until it reaches total
        if (displayedCount < total)
        {
            // iterate position in frame delay cycle
            frameCount = (frameCount + 1) % frameDelay;

            // update only on complete delay cycles
            if (frameCount == 0)
            {
                displayedCount++;
                display.text = " x " + displayedCount;
            }
        }

	}
}
