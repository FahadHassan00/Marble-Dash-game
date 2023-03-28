using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faketext : MonoBehaviour
{
  
    public GameObject fakeholetext;
    // Start is called before the first frame update
    void Start()
    {
        turonoff();
    }
  


    public void turonoff()
    {
        StartCoroutine("off");
    }
    IEnumerator off()
    {
        yield return new WaitForSeconds(2);
        fakeholetext.SetActive(false);
    }
}
