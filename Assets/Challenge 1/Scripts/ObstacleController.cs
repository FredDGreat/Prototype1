using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    //rigidBody reference
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //get the rigidbody reference. This will enable control over performance of rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //freeze this gameObject upon colliding with another gameObject
        rb.freezeRotation = true;
    }
}
