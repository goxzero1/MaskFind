using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;
    public TimerScript timer;
    public GameObject transition;
    public Text totalFruits;
    public Text fruitsCollected;
    public int totalFruitsInLevel;
    public GameObject jump;
    public GameObject button;
    public GameObject lineartimer;
    public GameObject joy;
    public Text slash;
    public Text text;

    public void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }
    public void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }
    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            timer.timeLeft += 10;
            levelCleared.gameObject.SetActive(true);
            totalFruits.gameObject.SetActive(false);
            fruitsCollected.gameObject.SetActive(false);
            joy.gameObject.SetActive(false);
            lineartimer.gameObject.SetActive(false);
            jump.gameObject.SetActive(false);
            button.gameObject.SetActive(false);
            slash.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
            Invoke("transitioning", 0);
            Invoke("ChangeScene", 3);
            
        }
    }

    void transitioning()
    {
        transition.SetActive(true);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
