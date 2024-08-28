using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Item pickupDetails = new Item();
    public PuzzlePieces puzzleReference;

    // Start is called before the first frame update
    void Start()
    {
        //get reference to the object's puzzle script
        puzzleReference = GetComponent<PuzzlePieces>();
        //set the number that will be used by the inventory(itemID) to be the same as the puzzle code so that the puzzle's lock can check for it
        pickupDetails.itemID = (int)puzzleReference.puzzleID;


    }

    // Update is called once per frame
    void Update()
    {

    }
    //ontriggerenter check for collision
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log((collider.transform.name) + " has entered the pickup box");
        //if the collision is a player
        if (collider.transform.GetComponent<Player>())
        {

            //if collided add id code to player inventory

            //after pickup destroy this object

        }
    }
}
