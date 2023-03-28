using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramp : MonoBehaviour
{
   public  Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(100, 100, 100);
        }
    }
}
