using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation : MonoBehaviour
{
    public float speedh = 2.0f;
    public float speedv = 2.0f;
    // Start is called before the first frame update
    private float yaw;
    private float pitch;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {


            yaw += speedh * Input.GetAxis("Mouse X");
            //pitch -= speedv * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(0f, yaw, 0.0f);
        }
    }
}
