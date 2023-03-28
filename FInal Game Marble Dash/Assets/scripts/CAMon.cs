using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMon : MonoBehaviour
{
    public GameObject secondcam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Camon()
    {
        if (secondcam.activeInHierarchy == true)
        {
            secondcam.SetActive(false);
        }
        else
        {
            secondcam.SetActive(true);
        }
    }
}
