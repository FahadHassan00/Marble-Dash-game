using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    public float transTime = 1f;
    public Animator transtiton;
    public int scene;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadLevel(scene);
        }
    }
    public void LoadLevel(int scene)
    {
        StartCoroutine(LoadLeveler(scene));

    }
    IEnumerator LoadLeveler(int levelIndex)
    {
        transtiton.SetTrigger("Start");

        yield return new WaitForSeconds(transTime);
        SceneManager.LoadScene(levelIndex);
    }

}
