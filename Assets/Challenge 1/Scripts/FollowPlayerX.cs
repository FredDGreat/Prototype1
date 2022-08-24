using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //camera offset
    public Vector3 offset = new Vector3(0, 2, -8);
    //public Vector3 offset = new Vector3(-50, 5, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //follow the plane it goes forward
        transform.position = plane.transform.position + new Vector3(0, 2, -8);
        //make sure that the camera follows the plane when it rotates
        transform.rotation = plane.transform.rotation;
    }
}
