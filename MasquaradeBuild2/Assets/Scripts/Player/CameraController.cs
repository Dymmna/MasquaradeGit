using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Range(0f, 10f)]
    public float sensitivity = 1f;

    [SerializeField]
    float rightLimit;
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float bottomLimit;
    [SerializeField]
    float upLimit;


    private void Start()
    {
        SetCamera(true);

    }
    void LateUpdate()
    {

        SetCamera();
    }

    void SetCamera(bool init = false)
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        if (init) cameraPosition = transform.position;
        else cameraPosition = Vector2.Lerp(cameraPosition, transform.position, Time.deltaTime * sensitivity);

        cameraPosition.z = Camera.main.transform.position.z;
        Camera.main.transform.position = cameraPosition;

        Camera.main.transform.position = new Vector3
            (
            Mathf.Clamp(Camera.main.transform.position.x, leftLimit, rightLimit),

             Mathf.Clamp(Camera.main.transform.position.y, bottomLimit, upLimit)
              , -10
            );
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(leftLimit, upLimit), new Vector2(rightLimit, upLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(rightLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, upLimit), new Vector2(leftLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(rightLimit, upLimit), new Vector2(rightLimit, bottomLimit));
    }



}
