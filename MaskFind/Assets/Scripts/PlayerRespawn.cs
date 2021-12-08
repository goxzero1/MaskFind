using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public TimerScript timerScript;
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    Rigidbody2D rigid;

    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    public void reachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPositionX",x);
        PlayerPrefs.SetFloat("checkPositionY",y);
    }

    public void OnDamaged(Vector2 targetPos)
    {



        rigid = GetComponent<Rigidbody2D>();
        int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;
        rigid.AddForce(new Vector2(dirc,1) * 4, ForceMode2D.Impulse);



    }

    public void PlayerDamaged()
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            timerScript.timeLeft += 1;
        }
    }



}
