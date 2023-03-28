using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GaneOverScreen : MonoBehaviour
{
    public Text pointsText;
    public int level;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "POINTS";
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
        gameObject.SetActive(false);

    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
