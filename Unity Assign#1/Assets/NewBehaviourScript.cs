using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rigidB;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidB.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidB.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidB.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidB.AddForce(Vector3.left * speed);
        }

    }
}
