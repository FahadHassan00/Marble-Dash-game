/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    public int sceneID;
    public Image loadingImg;
    public Text progressText;
    void start()
    {   
        StartCoroutine(AsyncLoad());
    }
    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            loadingImg.fillAmount = progress;

            progressText.text = string.Format("{0:0}%",progress*100);

            yield return null;
        }
    }
}*/
