using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public Item thisKey = new Item();
    public enum PuzzleID {Yellow = 1,Orange = 2,Red = 3,Blue = 4,Purple = 5, Green = 6}
    public PuzzleID puzzleID;
    // Start is called before the first frame update
    void Start()
    {

        // itemID is set to the puzzleID number
        thisKey.itemID = (int)puzzleID;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
