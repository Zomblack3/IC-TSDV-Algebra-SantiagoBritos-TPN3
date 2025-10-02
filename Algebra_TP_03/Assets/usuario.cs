using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usuario : MonoBehaviour
{
    public float userSpeed = 10.0f;
    public float userRotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        Vector3 movement = new Vector3(horizontalInput, scrollInput, verticalInput);

        movement.Normalize();

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * userSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * userSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * userSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * userSpeed * Time.deltaTime);

        //transform.position += movement * userSpeed * Time.deltaTime;
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), userRotationSpeed * Time.deltaTime);

        //Input.GetKey(KeyCode.LeftShift);

        //if (movement != Vector3.zero)
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), userRotationSpeed * Time.deltaTime);

        //transform.Rotate(Vector3.up, mouseX * userRotationSpeed * Time.deltaTime, Space.World);
        //transform.Rotate(Vector3.right, mouseY * userRotationSpeed * Time.deltaTime, Space.World);
    }
}
