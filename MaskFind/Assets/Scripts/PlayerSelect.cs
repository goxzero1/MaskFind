using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool enableselectCharactor;
    public enum Player { Pinkman, Frog };
    public Player playerSelected;

    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public RuntimeAnimatorController[] playerController;
    public Sprite[] playerRenderer;

    void Update()
    {
        if (!enableselectCharactor)
        {
            ChangePlayerInMenu();
        }
        else
        {
            switch (playerSelected)
            {
                case Player.Pinkman:
                    spriteRenderer.sprite = playerRenderer[0];
                    animator.runtimeAnimatorController = playerController[0];
                    break;
                case Player.Frog:
                    spriteRenderer.sprite = playerRenderer[1];
                    animator.runtimeAnimatorController = playerController[1];
                    break;
                default:
                    break;
            }
        }

    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Pinkman":
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playerController[0];
                break;
            case "Frog":
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playerController[1];
                break;
            default:
                break;
        }
    }
}
