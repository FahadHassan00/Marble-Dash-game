using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fakehole : MonoBehaviour
{
    public respawn rm;
    // public MeshRenderer ball;
    public Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            ball.constraints = RigidbodyConstraints.FreezeAll;
            ball.constraints = RigidbodyConstraints.None;
            ball.constraints = RigidbodyConstraints.FreezePositionY;
            //ball.enabled = false;
            rm.respawnmarble();
        }
    }
  
}
