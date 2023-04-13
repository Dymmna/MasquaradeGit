using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InLocationTeleport : MonoBehaviour
{
    public Transform LocationStartPosition;
    public Transform Location;


    public void Move()
    {
        StartCoroutine(WaitForIt());

    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.5f);
        PlayerController pc = FindObjectOfType<PlayerController>();
        if (pc != null)
        {
            pc.transform.position = (Vector2)LocationStartPosition.position;
            Vector3 camPos = Camera.main.transform.position;
            camPos = Location.transform.position;
            camPos.z = Camera.main.transform.position.z;
            Camera.main.transform.position = camPos;
        }
        else Debug.LogError("На персонаже нет скрипта Player Controller");
    }

}
