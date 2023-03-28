using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombexplosion : MonoBehaviour
{
    //[SerializeField] GameObject explode;
    public GameObject explosion;
    public dragandshoot ds;
    public Rigidbody marble;
    respawn rm;

    void Start()
    {
        rm = GetComponent<respawn>();
        ds = GetComponent<dragandshoot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bomb"))
        {
            marble.constraints = RigidbodyConstraints.FreezeAll;
            marble.constraints = RigidbodyConstraints.None;
            marble.constraints = RigidbodyConstraints.FreezePositionY;
            explosion.SetActive(true);
            SoundManager.playsound("explosion");
            rm.respawnmarble();
            ds.stopcorutines();
        }
    }
}
