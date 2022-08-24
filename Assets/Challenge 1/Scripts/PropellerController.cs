using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    //propeller speed
    public float speed = 35f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //start rotating the propeller
        transform.Rotate(Vector3.forward * speed);
    }
}
