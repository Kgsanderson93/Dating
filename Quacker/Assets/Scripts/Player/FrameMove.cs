using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameBehavior: MonoBehaviour
{
    public float moveSpeed=2;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

    }
}
