using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{

    [Header("Car Setting")]

    public float accelerationFactor = 30.0f;
    public float turnFactor = 3.5f;
    public float driftFactor = 0.95f;
    public float maxSpeed = 10;

    float accelerationInput = 0f;
    float steeringInput = 0f;

    float rotationAngle = 0f;

    float velocityVsUp = 0;

    Rigidbody2D carBody;

    private void Awake()
    {
        carBody = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        ApplyEngineforce();

        KillOrthogonalVelocity();

        ApplySteeringForce();
    }

    void ApplyEngineforce()
    {
        velocityVsUp = Vector2.Dot(transform.up, carBody.velocity);

        if(velocityVsUp > maxSpeed && accelerationInput > 0)
        {
            return;
        }
        if(velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
        {
            return;
        }

        if(carBody.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
        {
            return;
        }

        if(accelerationInput == 0)
        {
            carBody.drag = Mathf.Lerp(carBody.drag, 3.0f, Time.fixedDeltaTime * 3);
        }
        else
        {
            carBody.drag = 0f;
        }

        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        carBody.AddForce(engineForceVector, ForceMode2D.Force);
    }

    void ApplySteeringForce()
    {
        float minSpeedForceAllowTurningFactor = (carBody.velocity.magnitude / 8);

        minSpeedForceAllowTurningFactor = Mathf.Clamp01(minSpeedForceAllowTurningFactor);

        rotationAngle -= steeringInput * turnFactor * minSpeedForceAllowTurningFactor;

        carBody.MoveRotation(rotationAngle);
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;

        accelerationInput = inputVector.y;
    }

    void KillOrthogonalVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(carBody.velocity, transform.up);

        Vector2 rightVelocity = transform.right * Vector2.Dot(carBody.velocity, transform.right);

        carBody.velocity = forwardVelocity + rightVelocity * driftFactor;
    }
}
