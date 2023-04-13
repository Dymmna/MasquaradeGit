using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroParameters : MonoBehaviour
{

    public int health = 10;
    public int shield = 0;
    public float speed = 5;


    public void AddHealth()
    {
        health += 5; 

    }

    public void AddShield()
    {
        shield += 1;

    }
    
    public void AddSpeed()
    {
        speed = 10;

    }
}
