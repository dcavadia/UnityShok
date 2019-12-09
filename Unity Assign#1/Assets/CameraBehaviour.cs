using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Rigidbody rigidB;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rigidB.transform.position + offset;
    }
}

