using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelSelect : MonoBehaviour
{
    public Button[] levelbuttons;

   void start()
    {
        int levelreached = PlayerPrefs.GetInt("levelreached", 1);

        for (int i = 0; i < levelbuttons.Length; i++)
        {
            if(i+1>levelreached)
            levelbuttons[i].interactable  = false;
        }
    }
  public void selectLevel(int level)
    {
        marblelives.marbles = 5;
        SceneManager.LoadScene(level);
        
    }
}
