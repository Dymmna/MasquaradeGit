using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    HeroParameters heroParameters;


    public enum powerUpId
    {
        Potion, Shield, Mushroom
    }

    public powerUpId powerUp;
    
   private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           heroParameters = collision.GetComponent<HeroParameters>();

            switch (powerUp)
            {
                case powerUpId.Potion: heroParameters.AddHealth();
                    break;

                case powerUpId.Shield:heroParameters.AddShield();
                    break;

                case powerUpId.Mushroom: heroParameters.AddSpeed();
                    break;

                default: Debug.Log("idk what it is");
                    break;
            }
        }
    }
}
