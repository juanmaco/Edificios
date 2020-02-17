using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 0.1f;
    public float rotationSpeedNegative = -0.1f;
    private float rotationY = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, rotationSpeedNegative, 0);
        }

    }
}
