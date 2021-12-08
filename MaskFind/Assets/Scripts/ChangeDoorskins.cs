using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoorskins : MonoBehaviour
{
    public GameObject skinsPanel;
    private bool inDoor = true;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        skinsPanel.gameObject.SetActive(false);
        inDoor = false;
    }

    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("PlayerSelected", "PinkMan");
        ResetPlayerSkin();
    }

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
