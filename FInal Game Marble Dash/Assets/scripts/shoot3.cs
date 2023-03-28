using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot3 : MonoBehaviour
{
    private Vector3 mousepressdownpos;
    private Vector3 mousereleasepos;

    private Rigidbody rb;

    private bool isShoot;

    //public LineRenderer lr;

    public GameObject camera2;
    // public float maxdrag = 5f;
    // public float power = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        Vector3 forceinit = (Input.mousePosition - mousepressdownpos);
        Vector3 forcev = (new Vector3(forceinit.x, forceinit.y, forceinit.y) * forcemultiplier);

        if (!isShoot)
        {
            trajectory3.Instance.lr.gameObject.SetActive(true);
            trajectory3.Instance.updatetrajectory(forcev, rb, transform.position);
        }


    }
    private void OnMouseDown()
    {
        mousepressdownpos = Input.mousePosition;
        //lr.gameObject.SetActive(true);
        //lr.SetPosition(0, transform.position);
        //lr.SetPosition(1, transform.position + transform.forward * 10f);
    }
    private void OnMouseUp()
    {
        trajectory3.Instance.Hideline();
        camera2.SetActive(true);
        mousereleasepos = Input.mousePosition;
        shoot(mousepressdownpos - mousereleasepos);
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
        rb.AddForce(new Vector3(force.x, force.y, force.y) * forcemultiplier);
        isShoot = true;
    }
}
