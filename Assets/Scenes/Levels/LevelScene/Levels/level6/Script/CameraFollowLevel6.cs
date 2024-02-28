using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLevel6 : MonoBehaviour
{
    public Transform target; // The player's transform to follow
    public Vector3 offset; // Offset of the camera from the target
    public float smoothSpeed = 0.125f; // Smoothness of the camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
