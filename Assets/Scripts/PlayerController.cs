using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    public float speed = 8;
    public float rotationSpeed = 40;
    private Vector2 direction;
    [Range(0, 10)]
    public float mouseSensitivity = 2f; 
    private bool movementEnabled = true;

    public CameraScript cameraScript;
    

    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
            RotateWithMouse();
            MoveWithKeys();
    }

    void RotateWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX * rotationSpeed * Time.deltaTime);
    }
    void MoveWithKeys()
    {
            transform.position += transform.right * (speed * Time.deltaTime * direction.x);
            transform.position += transform.forward * (speed * Time.deltaTime * direction.y);
            
            print(transform.position);
            print(direction);
    }

    public void move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    
    public void SwitchFPS(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (context.performed)
            {
                cameraScript.FPSSwitch();
            }
        }
    }
    
    public void SwitchCameraLVL1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (context.performed)
            {
                cameraScript.CLVL1Switch();
            }
        }
    }
    
    public void SwitchCameraLVL2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (context.performed)
            {
                cameraScript.CLVL2Switch();
            }
        }
    }
}