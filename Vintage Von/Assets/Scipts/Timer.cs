using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float timeValue = 90;
    public Text timeText;

    //public CameraShaker cameraShaker; 
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0; 
        }

        if(timeValue <= 0)
        {
            SceneManager.LoadScene(3);
        }

        if(timeValue <= 2)
        {
            //CameraShaker.Shake(0.15f, 0.3f);
            GameObject autoSet = GameObject.FindGameObjectWithTag("AutoSoundDeath");
            GameObject deathsound = autoSet.GetComponent<DeathSound>().auto;
            deathsound.SetActive(true);
        }

        if(timeValue <= 3)
        {
            ShakeCameraCin.Instance.ShakeCamera(10f, 3f);
        }

        DisplayTime(timeValue);
    
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay<0)
        {
            timeToDisplay = 0;
        }
        float min = Mathf.FloorToInt(timeToDisplay/60);
        float sec = Mathf.FloorToInt(timeToDisplay%60);

        timeText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
