using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
   
    Image timerBar;
    public float maxTime = 5f;
    public float timeLeft;
    
   
    void Start()
    {
        
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft = timeLeft - Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }

        else
        {
            
            SceneManager.LoadScene("GameOver");
        }

       

    }

   

}
