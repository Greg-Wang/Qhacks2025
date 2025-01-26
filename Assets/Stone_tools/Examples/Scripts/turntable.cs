
//
// turntable
// Daniel Robnik
// 10 06 2016
//

using UnityEngine;
using System.Collections;

//
// This script rotates the parent object at the specified speed around the global up axis.
//

public class turntable : MonoBehaviour
{
    // Public variables.

    public float rotation_speed = 90.0f;

    // Private variables.

    private Transform c_transform;
    
    //
    // Default Unity3d Start method.
    //

    void Start()
    {
        c_transform = GetComponent<Transform>();
    }

    //
    // Default Unity3d Update method.
    //

    void Update()
    {
        c_transform.Rotate(Vector3.up, Time.deltaTime * rotation_speed, Space.World);
    }
}
