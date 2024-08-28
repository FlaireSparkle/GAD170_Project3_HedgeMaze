using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using static PuzzlePieces;
[SerializeField] //check if needed
public class PuzzlePieces : MonoBehaviour
{

    public enum PuzzleID { Green = 0, Yellow = 1, Orange = 2, Red = 3, Blue = 4, Purple = 5, Legendary = 6}
    public PuzzleID puzzleID;
    public Material puzzleMaterial;
    public Material furnitureMaterial;
    public MeshRenderer puzzleMeshRenderer;
    public MeshRenderer completedPuzzleMeshRenderer;
    public string objectType = "empty";
    public bool isOpen = false;
    /////public Item pickupDetails = new Item();

    // Start is called before the first frame update
    void Start()
    {
        puzzleMeshRenderer.material = puzzleMaterial;
        completedPuzzleMeshRenderer.material = furnitureMaterial;
        SetMaterial(false);
        SetName();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetMaterial(bool isOpen)
    {
        if (isOpen == false)
        {
            puzzleMeshRenderer.material = puzzleMaterial;
            ChangeColour(puzzleMeshRenderer.material);
        } else if (isOpen == true)
        {
            completedPuzzleMeshRenderer.material = puzzleMaterial;
            ChangeColour(completedPuzzleMeshRenderer.material);

        }
    }
    public void ChangeColour(Material materialToChange)
    { 
        switch (puzzleID)
        {
            case PuzzleID.Green: 
                {
                    materialToChange.color = new Color((0f / 225f), (200f / 225f), (0f / 225f));
                    break;
                }
            case PuzzleID.Yellow:
                {
                   materialToChange.color = new Color((225f / 225f), (200f / 225f), (0f / 225f));
                    break;
                }
            case PuzzleID.Orange:
                {
                    materialToChange.color = new Color((225f / 225f), (111f / 225f), (0f / 225f));
                    break;
                }
            case PuzzleID.Red:
                {
                    materialToChange.color = new Color((139f / 225f), 0f, 0f);
                    break;
                }
            case PuzzleID.Blue:
                {
                    materialToChange.color = new Color((0f / 225f), (111f / 225f), (200f / 225f));
                    break;
                }
            case PuzzleID.Purple:
                {
                    materialToChange.color = new Color((150f / 225f), (0f / 225f), (255f / 225f));
                    break;
                }
            case PuzzleID.Legendary:
                {
                    //this changes it to a grey colour
                    materialToChange.color = new Color((80f / 225f), (82f / 225f), (80f / 225f));
                    break;
                }
        }
    }
    public void SetName()
    {
        switch (puzzleID)
        {
            case PuzzleID.Green:
                {
                    name = "Green " + objectType;
                    break;
                }
            case PuzzleID.Yellow:
                {
                    name = "Yellow " + objectType;
                    break;
                }
            case PuzzleID.Orange:
                {
                    name = "Orange " + objectType;
                    break;
                }
            case PuzzleID.Red:
                {
                    name = "Red " + objectType;
                    break;
                }
            case PuzzleID.Blue:
                {
                    name = "Blue " + objectType;
                    break;
                }
            case PuzzleID.Purple:
                {
                    name = "Portal " + objectType;
                    break;
                }
            case PuzzleID.Legendary:
                {
                    name = "Ledgendary " + objectType;
                    break;
                }
        }

    }
   
}
