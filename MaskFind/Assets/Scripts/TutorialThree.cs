using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialThree : MonoBehaviour
{
   
    public GameObject GameObject;
    public GameObject GameObject2;
    void Update()
    {
        GameObject.gameObject.SetActive(true);


        if (Input.GetMouseButtonDown(0))
        {
            GameObject2.gameObject.SetActive(true);
            Invoke("transe", 3);
        }
    }

    void transe()
    {
        SceneManager.LoadScene("MainMenu");
    }
   
}
