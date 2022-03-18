using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript : MonoBehaviour
{
    public float rotationSpeed = 360f;
    public float traslationSpeed = 0.9856468f;
    public Transform earthTransform;


    // Update is called once per frame
    void Update()
    {
        earthTransform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.Self);
        transform.Rotate(Vector3.up * Time.deltaTime * traslationSpeed, Space.World);
    }
}
