using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public GameObject yarnMaster;
    public int pointsToAdd;
    // Start is called before the first frame update
    void Start()
    {
            yarnMaster.GetComponent<YarnMaster>().goodPoints += pointsToAdd;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
