using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] FloorTile tile1;
    [SerializeField] FloorTile tile2;
    [SerializeField] FloorTile tile3;
    [SerializeField] FloorTile tile4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            tile1.status = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            tile2.status= 1;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            tile3.status = 1;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            tile4.status = 1;
        }
    }
}
