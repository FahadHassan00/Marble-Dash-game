using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawn : MonoBehaviour
{
    public Vector3 respawn1;
    public Rigidbody rb;
    public GameObject secondcam;
    dragandshoot dr;
    public float speed;
    public GameObject explosion;
    public Sprite bgmarble;
    public Sprite fmarble;
    public int marblelivesImage;
    public Image[] marlives;
    public MeshRenderer marble1;
    public GameObject camerabutton;
    //public  GameObject gameplaybarrier;
    //public GameObject fakecam;
    float time=0f;
    public float timedelay=5f;
    public Transform hole;
    void Start()
    {
        respawn1 = transform.position;
        dr = FindObjectOfType<dragandshoot>();
        //marlives = GameObject.FindGameObjectWithTag("hb").GetComponent<Image>();
       
    }

    // Update is called once per frame

    //private void LateUpdate()
    //{
    //    if (speed <= 0)
    //    {
    //        marblelives.marbles--;
    //    }
    //}
    private void Update()
    {
        
        speed = Mathf.Abs(rb.velocity.z);
        //speed = rb.velocity.z;
        //if (speed < 0)
        //{
        //    marblelives.marbles--;
        //}
        for (int i = 0; i < marlives.Length; i++)
        {
            if(i<marblelives.marbles)
            {
                marlives[i].sprite= fmarble;
            }
            else
            {
                marlives[i].sprite= bgmarble;
            }

            if (i < marblelivesImage)
            {
                marlives[i].enabled=true;
            }
            else
            {
                marlives[i].enabled = false;
            }
        }
    }
    private void FixedUpdate()
    {
        time = time + 1f * Time.deltaTime;
        if (time >= timedelay)
        {
            if (speed <= 1.4)
            {
                time = 2f;
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                transform.eulerAngles = Vector3.zero;
                dr.isShoot = false;
                
                //secondcam.SetActive(false);
                //rb.constraints = RigidbodyConstraints.FreezePositionY;
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("reset"))
        {
            respawnmarble();
        }
    }
    public void respawnmarble()
    {
        //gameplaybarrier.SetActive(false);
        marble1.enabled = false;
        StartCoroutine("Delay");
        
    }

    IEnumerator Delay()
    {
        
        yield return new WaitForSeconds(0.5f);
        explosion.SetActive(false);
        marble1.enabled = true;
        transform.position = respawn1;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        //marblelives.marbles--;
        transform.eulerAngles = Vector3.zero;
        //secondcam.SetActive(false);
        dr.isShoot = false;
        camerabutton.SetActive(true);
      



    }
}
