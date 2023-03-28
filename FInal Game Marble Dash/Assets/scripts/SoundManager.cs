using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static AudioSource src;
    
    static AudioClip roll,explosion,gameover,levelcomplete,confetti;
    // Start is called before the first frame update
    void Start()

    {
        src = GetComponent<AudioSource>();
        //    jump = Resources.Load<AudioClip>("jump2");
        explosion = Resources.Load<AudioClip>("explosion");
        roll = Resources.Load<AudioClip>("roll");
        gameover= Resources.Load<AudioClip>("fail");
        levelcomplete = Resources.Load<AudioClip>("win");
        confetti = Resources.Load<AudioClip>("confetti");

    }

    public static void playsound(string clipname)
    {
        switch (clipname)
        {
            

            case "roll":
                src.volume = 0.6f;
                src.PlayOneShot(roll);
                break;
            case "explosion":
                src.volume = 0.6f;
                src.PlayOneShot(explosion);
                break;
            case "win":
               
                src.PlayOneShot(levelcomplete);
                break;
            case "fail":
                
                src.PlayOneShot(gameover);
                break;
            case "confetti":
                src.PlayOneShot(confetti);
                break;

        }
    }
}
