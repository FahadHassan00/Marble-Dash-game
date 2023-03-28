using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hole : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject LevelComplete1;
    public GameObject LevelComplete2;
    public GameObject LevelComplete3;
    public GameObject confetti;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        { 
            if(marblelives.marbles==4)
            {
                SoundManager.playsound("confetti");
                LevelComplete1.SetActive(true);
                confetti.SetActive(true);
                //Time.timeScale = 1f;
                //GameIsPaused = false;
                SoundManager.playsound("win");
                Destroy(collision.gameObject);
                Stat();
                
            }
            else if(marblelives.marbles ==3 || marblelives.marbles == 2)
            {
                SoundManager.playsound("confetti");
                confetti.SetActive(true);
                LevelComplete2.SetActive(true);
                //Time.timeScale = 1f;
                //GameIsPaused = false;
                Destroy(collision.gameObject);
                Stat();
               
            }
            else if (marblelives.marbles == 1 || marblelives.marbles == 0){
                SoundManager.playsound("confetti");
                LevelComplete3.SetActive(true);
                confetti.SetActive(true);
                //Time.timeScale = 1f;
                //GameIsPaused = false;
                Destroy(collision.gameObject);
                Stat();
               
            }




        }
    }
        public void Stat()
        {
            StartCoroutine("Delay2");
        }
        IEnumerator Delay2()
        {

            yield return new WaitForSeconds(3f);
            confetti.SetActive(false);
            marblelives.marbles = 5;
            SceneManager.LoadScene(1);
    }
   
}
