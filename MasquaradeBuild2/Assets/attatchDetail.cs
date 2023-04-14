using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class attatchDetail : MonoBehaviour
{
    private Transform detailPosition;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public static bool locked;

    public Color activeColor;
    public static Color _activeColor;

    public string NewLevel = "Place name here";

    // Start is called before the first frame update
    void Awake()
    {
        _activeColor = activeColor;
    }
    void Start()
    {       
        StartCoroutine(DetailContr());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator DetailContr()
    {
        GameObject[] details = GameObject.FindGameObjectsWithTag("detail");
        while (true)
        {
            bool allInPlace = true;
            foreach (GameObject detail in details)
            {
                if (!detail.GetComponent<placePosition>().placeMe)
                {
                    allInPlace = false;
                    break;
                }
            }
            if (allInPlace)
            {
                
                Debug.Log("VSE SOBRALY");
                StopAllCoroutines();
                //сюда смена сцены

            }
            yield return new WaitForSeconds(1f);
        } 
    }
}
