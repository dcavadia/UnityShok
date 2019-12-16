using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlane : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 velocity = Vector3.up;
    public float smooth = 4.0F;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * 12.0f;
        float tiltAroundX = Input.GetAxis("Vertical") * 12.0f;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, 10.0F);
    }
}
