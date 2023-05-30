using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    
    [SerializeField] float rotationSpeed = 5f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 d = new Vector3(h, 0, v);
        transform.Translate(d * movementSpeed * Time.deltaTime);


        /*        if(Input.getkey)*/


        float mX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mY = Input.GetAxis("Mouse Y") * rotationSpeed;
        Vector3 r = new Vector3(mY, mX, 0);
        transform.Rotate(mY, mX, 0);
    }
}
