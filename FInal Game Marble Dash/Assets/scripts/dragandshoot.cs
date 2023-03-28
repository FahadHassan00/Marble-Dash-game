using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class dragandshoot : MonoBehaviour
{

    private Vector3 mousepressdownpos;
    private Vector3 mousereleasepos;

    private Rigidbody rb;

    public  bool isShoot;

    //public LineRenderer lr;

    public GameObject camera2;
    // public float maxdrag = 5f;
    // public float power = 10f;
    public GameObject cam2button;
    //public GameObject gameplaybarrier;
    public respawn rm;
    //public GameObject fakecam;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

        
    }


    private void Update()
    {
        
    }


    private void OnMouseDrag()
    {
        
        Vector3 forceinit = (Input.mousePosition - mousepressdownpos);
        Vector3 forcev = (new Vector3(forceinit.x, forceinit.y, forceinit.y) * forcemultiplier);

        if (!isShoot)
        {
            trajectory.Instance.lr.gameObject.SetActive(true);
            trajectory.Instance.updatetrajectory(forcev, rb, transform.position);
        }


    }
    private void OnMouseDown()
    {
        
        //camera2.SetActive(false);
        mousepressdownpos = Input.mousePosition;
        //lr.gameObject.SetActive(true);
        //lr.SetPosition(0, transform.position);
        //lr.SetPosition(1, transform.position + transform.forward * 10f);
    }
    private void OnMouseUp()
    {
        //gameplaybarrier.SetActive(true);

        stop();
        marblelives.marbles--;
        trajectory.Instance.Hideline();
        //camera2.SetActive(true);
        mousereleasepos = Input.mousePosition;
        shoot(mousepressdownpos - mousereleasepos);
        cam2button.SetActive(false);
    }
    public float forcemultiplier = 3;
    void shoot(Vector3 force)
    {
        if (isShoot)
        {

            return;
        }
        //Vector3 Force = force;
        //Vector3 clampedforce = Vector3.ClampMagnitude(force, maxdrag) *power;

        //rb.AddForce(clampedforce, ForceMode.Impulse);
        rb.AddForce(new Vector3(force.x, 0f, force.y) * forcemultiplier);
        isShoot = true;
    }
    public void stopcorutines()
    {
        StopAllCoroutines();
    }

    public void stop()
    {
        StartCoroutine("stop1");
    }
    IEnumerator stop1()
    {
        yield return new WaitForSeconds(3f);
        
        //rb.constraints = RigidbodyConstraints.None;
        //rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;
        //transform.eulerAngles = Vector3.zero;
        //rm.respawnmarble();
        //yield return new WaitForSeconds(3f);
        //rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;
        //transform.eulerAngles = Vector3.zero;
        ////rm.respawnmarble();
        //camera2.SetActive(false);
        //isShoot = false;
        //marblelives.marbles--;
    }
}
