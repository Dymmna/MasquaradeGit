using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictMovement : MonoBehaviour
{
    private Transform objTransform;

    float speed = 0;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
      
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.94f, 2.02f), Mathf.Clamp(transform.position.y, -3.3f, 3.44f), transform.position.z);

    }

}
