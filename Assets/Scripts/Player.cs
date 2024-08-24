using UnityEngine;
public class Player : MonoBehaviour
{
    public string myClass = "Player";
    public int myLevel = 0;
    public Stats myStats = new Stats();
    private int currentHealth = 0;
    public Inventory inventory = new Inventory();
    // Start is called before the first frame update
    void Start()
    {
        //Set connected object's name the same as in the script
        name = myClass;
        LevelUp();
        
    }
    public void CheckInventory()
    {
        
    }
    private void LevelUp()
    {
        myLevel++;
        myStats.SetStats(myClass, myLevel);
        FullHeal();
    }
    private void FullHeal()
    { currentHealth = myStats.maxHealth; }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this is a getter and setter. it can be used to allow access to a private variable (each blue bit can be made public or private seperate from eachother)
    public int PlayerHealth
    {
        //anywhere left of = is a get
        get
        {
            Debug.Log("maxHealth is " + currentHealth);
            //always have return last in a section
            return currentHealth;
        }
        //anywhere right of = is a set
        set
        {
            //check if being healed (not max healed)
            if (value > 0)
            {
                //use this space to enter conditions that happen when being healed.
                Debug.Log("Healing");
            }
            //check if taking damage
            else if (value < 0)
            {
                //use this space to enter conditions that happen when taking damage.
                Debug.Log("Taking Damage");
            }
            // += is used below so we can have the maxHealth go up and down with an if else if statement above.
            currentHealth += value;
            Debug.Log("maxHealth is " + currentHealth);
        }
    }
}
