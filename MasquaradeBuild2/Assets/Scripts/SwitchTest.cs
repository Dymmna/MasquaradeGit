using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public string day = "Monday";

    public string timeOfDay = "Morning";


    public int apples = 5;


    [Header("List of npc's")]
    public GameObject npc1;
    public GameObject npc2;

    //WEAPONLIST    
    public enum weaponType
    {
      None = 0, Pistol = 5, Gun = 40
    }

public float attackForce = 0f;

public weaponType type;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ChangeDay()
    {
        switch (day)
        {
            case "Monday":

                switch (timeOfDay)
                {
                    case "Morning":
                        Debug.Log("New NPC");
                        npc1.SetActive(true);
                        break;

                    case "Noon":
                        Debug.Log("our npc went to dinner");
                        npc1.SetActive(false);
                        break;

                    case "Evening":
                        Debug.Log("everyone gone home");
                        npc2.SetActive(true);
                        break;

                    default:
                        Debug.Log("idk this time of day");
                        break;
                }


                Debug.Log("ploho");
                break;


            case "Tuesday":
                Debug.Log("new event");
                break;


            case "Wednesday":
                Debug.Log("aaa");
                break;

            default:
                Debug.Log("something wrong");
                break;
        }
    }

    void CheckApples()
    {
        switch(apples)
        {
            case 5:
                Debug.Log("i have 5 apples");
                break;

            case 4:
                Debug.Log("i have 4 apples");
                break;

            case 3:
                Debug.Log("i have 3 apples");
                break;

            case 2:
                Debug.Log("i have 2 apples");
                break;

            case 1:
                Debug.Log("i have 5 apples");
                break;


            default :
                Debug.Log("what is an apple");
                break;  
        }
    }

    void ChangeWeapon()
    {
        switch (type.ToString())
        {
            case "Pistol": attackForce = type.GetHashCode();
                break;

            case "Gun": attackForce = type.GetHashCode();
                break;

            case "None":  attackForce = type.GetHashCode();
                break;

            default:
                Debug.Log("i can't kill everyone :( ");
                break;
        }   
    
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDay();
        CheckApples();
        ChangeWeapon();
    }
}
