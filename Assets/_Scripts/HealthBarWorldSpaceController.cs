using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCameraTransform;
    public GameObject playerCamera;

    void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera");

        if(playerCamera)
        {
            playerCameraTransform = playerCamera.transform;
        }
    }


    void LateUpdate()
    {
        // billboard the healthBar
        if(playerCameraTransform)
        {
            transform.LookAt(transform.position + playerCameraTransform.forward);
        }
    }
}
