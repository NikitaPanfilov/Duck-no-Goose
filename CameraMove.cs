using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
 public float mouseSensitivity = 100f;
 float xRotation = 0f;
    float YRotation = 0f;
 


    // Start is called before the first frame update
    void Start()
    {
     Cursor.lockState = CursorLockMode.Locked;   
    }

    // Update is called once per frame
    void Update()
    {
 float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
     
       xRotation -= mouseY;
 

       xRotation = Mathf.Clamp(xRotation, -90f, 90f);
 

       YRotation += mouseX;
 

       transform.localRotation = Quaternion.Euler(xRotation, YRotation, 0f);

    }
}
