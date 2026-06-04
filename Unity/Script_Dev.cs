using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Script_Dev : MonoBehaviour
{
    public float WalkSpeed = 3f;

    public float JumpHeight = 0.6f;

    public float Gravity = -9.81f;

    public float _xRotation;

    public float MouseSensitivity = 2f;

    public Transform PlayerCamera;

    private CharacterController _charController;

    private float _verticalVelocity;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Movement();
        MousePlayer();
    }

    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal +
                       transform.forward * vertical;

        move = Vector3.ClampMagnitude(move, 1f);
        if (_charController.isGrounded && _verticalVelocity < 0)
        {
            _verticalVelocity = -2f;
        }
        if (Input.GetButtonDown("Jump") && _charController.isGrounded)
        {
            _verticalVelocity = Mathf.Sqrt(JumpHeight * -2f * Gravity);
        }

        _verticalVelocity += Gravity * Time.deltaTime;
        move.y = _verticalVelocity;

        _charController.Move(move * WalkSpeed * Time.deltaTime);
    }

    void MousePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity;
        transform.Rotate(Vector3.up * mouseX);
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -80f, 80f);

        PlayerCamera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
    }
}