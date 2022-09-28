using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mirge : MonoBehaviour
{
    public bool playerTouch = false;

    private PlayerController thePlayer;
    //public GameObject doorOpenSprite;
    //public GameObject doorOpenSprite1;
    //public GameObject doorOpenSprite2;
    //public GameObject doorOpenSprite3;
    public GameObject game;

    public bool waitingToOpen;
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }
    public void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Tomato.isCollected)
            {
                //doorOpenSprite.SetActive(true);
                spriteRender1.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.firstPos.gameObject.SetActive(false);
            }
            if (Tomato2.isCollected2)
            {
                //doorOpenSprite1.SetActive(true);
                spriteRender2.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.secondPos.gameObject.SetActive(false);
            }
            if (Tomato3.isCollected3)
            {
                //doorOpenSprite2.SetActive(true);
                spriteRender3.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.thirdPos.gameObject.SetActive(false);
            }
            if (Tomato4.isCollected4)
            {
                //doorOpenSprite3.SetActive(true);
                spriteRender4.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.forthPos.gameObject.SetActive(false);
            }

            if (Tomato4.isCollected4 && Tomato3.isCollected3 && Tomato2.isCollected2 && Tomato.isCollected)
            {
                game.SetActive(true);
            }
        }
    }
    //IEnumerator TimeDelay()
    //{
    //    yield return new WaitForSeconds(4);
    //}
}
