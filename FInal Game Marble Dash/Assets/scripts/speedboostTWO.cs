using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedboostTWO : MonoBehaviour
{
    public Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ball"))
        {
            ball.AddForce(100f, 0f, 600f);
            Destroy(gameObject);
        }
    }
}
