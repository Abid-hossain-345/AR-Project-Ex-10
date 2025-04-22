using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    [Header("Wheel Colliders")]
    public WheelCollider frontRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider backLeftWheelCollider;

    [Header("Wheel Transforms")]
    public Transform frontRightWheelTransform;
    public Transform frontLeftWheelTransform;
    public Transform backRightWheelTransform;
    public Transform backLeftWheelTransform;
    
    public Transform carCenterOfMass;
    public new Rigidbody rigidbody;

    [Header("Car Settings")]
    public float motorForce = 1500f;
    public float maxSteerAngle = 30f;
    public float brakeForce = 1000f;

    private float motorInput;
    private float steerInput;
    //private Rigidbody rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        rigidbody.centerOfMass = carCenterOfMass.localPosition;
    }

    void FixedUpdate()
    {
        GetCustomInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        ApplyBrakes();
    }

    void GetCustomInput()
    {
        // Forward/Backward
        if (Input.GetKey(KeyCode.D))
            motorInput = 1f;
        else if (Input.GetKey(KeyCode.A))
            motorInput = -1f;
        else
            motorInput = 0f;

        // Steer Right/Left
        if (Input.GetKey(KeyCode.W))
            steerInput = 1f;
        else if (Input.GetKey(KeyCode.S))
            steerInput = -1f;
        else
            steerInput = 0f;

        Debug.Log($"Motor Input: {motorInput}, Steer Input: {steerInput}");
    }

    void ApplyBrakes()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            frontRightWheelCollider.brakeTorque = brakeForce;
            backRightWheelCollider.brakeTorque = brakeForce;
            frontLeftWheelCollider.brakeTorque = brakeForce;
            backLeftWheelCollider.brakeTorque = brakeForce;
        }
        else
        {
            frontRightWheelCollider.brakeTorque = 0f;
            backRightWheelCollider.brakeTorque = 0f;
            frontLeftWheelCollider.brakeTorque = 0f;
            backLeftWheelCollider.brakeTorque = 0f;
        }
    }

    void HandleMotor()
    {
        frontRightWheelCollider.motorTorque = motorInput * motorForce;
        frontLeftWheelCollider.motorTorque = motorInput * motorForce;
    }
    void HandleSteering()
    {
        float steerAngle = steerInput * maxSteerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
        frontLeftWheelCollider.steerAngle = steerAngle;
    }

    void UpdateWheels()
    {
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
    }

    void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);

        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }
}
