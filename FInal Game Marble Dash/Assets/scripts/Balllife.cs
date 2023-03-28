using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Balllife : MonoBehaviour
{
    Image marblelife;
    void Start()
    {
        marblelife = GameObject.FindGameObjectWithTag("hb").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        marblelife.fillAmount = 0;
    }
}
