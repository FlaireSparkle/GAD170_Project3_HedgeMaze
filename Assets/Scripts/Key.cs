using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Item thisKey = new Item();


    // Start is called before the first frame update
    void Start()
    {
        thisKey.itemID = PuzzlePieces.PuzzleID.puzzleID;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
