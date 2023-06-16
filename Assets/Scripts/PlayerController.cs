using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float hInput;
    private float vInput;
    [SerializeField] float forwardSpeed = 20;
    [SerializeField] float turnSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * vInput * Time.deltaTime * forwardSpeed);

        transform.Rotate(Vector3.up * hInput * Time.deltaTime * turnSpeed);
        
    }
}
