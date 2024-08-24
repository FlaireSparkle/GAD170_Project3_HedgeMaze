using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public PuzzlePieces puzzleReference;
    // Start is called before the first frame update
    void Start()
    {
        puzzleReference = GetComponent<PuzzlePieces>();
    }

    /// <summary>
    /// This happens every time somthing with a collider enters the trigger range.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
        //if the collision is a player
        if(other.transform.GetComponent<Player>())
        {
            //check inventory itemID key matches  Lock puzzleID
            //CheckInventory((int)puzzleReference.puzzleID);

            //if true (has item) then unlock the door
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
