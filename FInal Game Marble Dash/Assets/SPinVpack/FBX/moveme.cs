 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 public class moveme : MonoBehaviour
{

    public float delta = 300.0f;  // Amount to move left and right from the start point
    public float speed = 300.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
