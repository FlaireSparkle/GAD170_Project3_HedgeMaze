using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Item thisKey = new Item();
    public PuzzlePieces puzzleReference;

    // Start is called before the first frame update
    void Start()
    {
        puzzleReference = GetComponent<PuzzlePieces>();
        thisKey.itemID = (int)puzzleReference.puzzleID;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
