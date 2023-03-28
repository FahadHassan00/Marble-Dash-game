using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    Button[] LevelButons;  
   
    private void Awake()
    {
        int ReacehedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);
        if (PlayerPrefs.GetInt("Level1") >= 2)
        {
            ReacehedLevel = PlayerPrefs.GetInt("Level1");
        }
        LevelButons = new Button[transform.childCount];
        for (int i=0;i<LevelButons.Length;i++)
        {
            LevelButons[i] = transform.GetChild(i).GetComponent<Button>();
            LevelButons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
            if(i+1>ReacehedLevel)
            {
                LevelButons[i].interactable = false;
            }
        }
    }
    public void LoadScene(int level)
    {
        PlayerPrefs.SetInt("Level", level);
        SceneManager.LoadScene(4);
    }
    void Update()
    {

    }
    
}
