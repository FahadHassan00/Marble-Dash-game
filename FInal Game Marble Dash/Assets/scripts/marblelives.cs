using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class marblelives : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    public static int marbles = 5;
    //public TextMeshProUGUI marbleleft;
    public Rigidbody marbel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //marbleleft.text = "x" + marbles.ToString();
        if (marbles == -1)
        {
            marbel.constraints = RigidbodyConstraints.FreezeAll;
            //SoundManager.playsound("fail");
            GameOver.SetActive(true);
            marbles = 5;
            
        }
    }
    
    public void setlives()
    {
        marblelives.marbles = 5;
    }
}
