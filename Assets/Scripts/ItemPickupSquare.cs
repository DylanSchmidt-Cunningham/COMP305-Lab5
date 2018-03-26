using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupSquare : MonoBehaviour {

    [HideInInspector]
    public bool isCollected = false;

    private static bool isCreated = false;

    private SpriteRenderer srend;
    private BoxCollider2D bc2d;

    void Awake()
    {
        if (!isCreated)
        {
            DontDestroyOnLoad(this.gameObject);
            isCreated = true;
        }
    }

    private void Start()
    {
        // store these for ease of access later
        srend = this.GetComponent<SpriteRenderer>();
        bc2d = this.GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // If the other object is a player, then switch camera
        if (other.gameObject.tag == "Player")
        {
            // just disable rendering and collision
            srend.enabled = false;
            bc2d.enabled = false;
        }
    }
}
