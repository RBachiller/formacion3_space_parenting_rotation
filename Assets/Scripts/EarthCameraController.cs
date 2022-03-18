using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthCameraController : MonoBehaviour
{
    public Transform earthTransform;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - earthTransform.position;
    }

    void LateUpdate()
    {
        transform.position = earthTransform.position + offset;
    }
}
