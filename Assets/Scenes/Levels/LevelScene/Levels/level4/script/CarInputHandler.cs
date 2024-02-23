using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    CarControl carControl;

    private void Awake()
    {
        carControl = GetComponent<CarControl>();
    }



    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        carControl.SetInputVector(inputVector);
    }
}
