using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialOneTwo : MonoBehaviour
{
    public GameObject GameObject;
    void Update()
    {
        GameObject.gameObject.SetActive(true);
       

        if (Input.GetMouseButtonDown(0))
        {
            
            Invoke("transe", 0);
        }
    }

    void transe()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
