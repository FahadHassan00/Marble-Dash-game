using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCon : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public float xoffset,yoffset,zoffset;
    //public float xangel, yangel, zangel;
    //public Transform camera2;
    public Vector3 offset;
    // public Vector3 velocity = Vector3.zero;
    //public float smoothtime;
    public float distance;
    void Start()
    {
        offset = transform.position -target2.position;
        //transform.position = target2.position+offset;
 
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, target2.position);
        //Vector3.Angle(target2.position, target.position);
        //offset = transform.position - target2.position;
        //Vector3 direction = target2.position+offset;
        //transform.position = new Vector3(0 , 0, target.position.z + offset.z);
        //transform.Rotate(offset, 90);
        //transform.position = Vector3.SmoothDamp(transform.position, direction,ref velocity, smoothtime);
        //transform.position = target2.transform.position + new Vector3(xoffset,yoffset,zoffset);
        //transform.position = target2.transform.position + offset;
        //transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime);
        //transform.eulerAngles = new Vector3(xangel, yangel, zangel);
        //transform.LookAt(target2.position);
        //transform.Rotate(new Vector3(1, 0, 0), offset.y*90);
        //transform.LookAt(target2.position);
        // transform.LookAt(target.position);
        //transform.rotation=Quaternion
        //transform.rotation = Quaternion.Euler(Vector3.Angle(target.position, target2.position), transform.rotation.y, transform.rotation.z);
    }
    private void LateUpdate()
    {
        //transform.position = target2.transform.position + new Vector3(xoffset, yoffset, zoffset);

        Vector3 holetoball = target2.position - target.position;
        Vector3 targetposition = target2.position + (holetoball.normalized * zoffset);
        targetposition.y = target2.position.y + yoffset;
        transform.position = targetposition;
        transform.LookAt(target.position);
        //transform.rotation = Quaternion.Euler(0f,0f , target.position.x);
        //target2.LookAt(target.position);
        //transform.parent.position = target2.position;
        //transform.parent.rotation = Quaternion.Euler(Vector3.Angle(target.position, target2.position), transform.rotation.y, transform.rotation.z);
    }
}
