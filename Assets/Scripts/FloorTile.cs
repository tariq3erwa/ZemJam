using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    public int status = 0;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(status == 1)
        {
            body.useGravity= true;
        }
    }
}
