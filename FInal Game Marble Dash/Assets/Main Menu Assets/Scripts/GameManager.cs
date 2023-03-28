using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Button[] lvlbuttons;
    // Start is called before the first frame update
    void Start()
    {
        int LevelAt = PlayerPrefs.GetInt("LevelAt", 2);
        for (int i=0;i<lvlbuttons.Length;i++)
        {
            if(i+2>LevelAt)
            {
                lvlbuttons[i].enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
