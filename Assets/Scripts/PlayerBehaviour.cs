using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    
    private float vInput;
    private float hInput;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleDot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * moveSpeed * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleDot);

        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }
}
