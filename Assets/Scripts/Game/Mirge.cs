using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mirge : MonoBehaviour
{
    public bool playerTouch = false;

    private PlayerController thePlayer;
    public GameObject game;
    public static bool isAllowdSound = true;

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
                spriteRender1.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.firstPos.gameObject.SetActive(false);
            }
            if (Tomato2.isCollected2)
            {
                spriteRender2.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.secondPos.gameObject.SetActive(false);
            }
            if (Tomato3.isCollected3)
            {
                spriteRender3.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.thirdPos.gameObject.SetActive(false);
            }
            if (Tomato4.isCollected4)
            {
                spriteRender4.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.forthPos.gameObject.SetActive(false);
            }
            if (Tomato4.isCollected4 && Tomato3.isCollected3 && Tomato2.isCollected2 && Tomato.isCollected)
            {
                if (isAllowdSound)
                {
                    AudioManager.instance.Play("pickup2");
                    isAllowdSound = false;
                }
                game.SetActive(true);
            }
        }
    }
}
