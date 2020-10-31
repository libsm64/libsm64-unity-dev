using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    LibSM64.SM64DynamicTerrain terrain;

    void Start()
    {
        terrain = GetComponent<LibSM64.SM64DynamicTerrain>();
    }

    void FixedUpdate()
    {
        terrain.SetRotation( Quaternion.AngleAxis( -20 * Time.time, Vector3.up ));
    }
}
