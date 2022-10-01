using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirgeBurgers : MonoBehaviour
{
    public bool playerTouch = false;

    private PlayerController thePlayer;
    public GameObject game;

    public bool waitingToOpen;
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Burger.isCollected_1)
            {
                SpiriteBurger1.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.firstPos.gameObject.SetActive(false);
            }
            if (Burger2.isCollected_2)
            {
                SpiriteBurger2.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.secondPos.gameObject.SetActive(false);
            }
            if (Burger3.isCollected_3)
            {
                SpiriteBurger3.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.thirdPos.gameObject.SetActive(false);
            }
            if (Burger4.isCollected_4)
            {
                SpiriteBurger4.sprite.color = new Color(255, 255, 255, 255);
                thePlayer.forthPos.gameObject.SetActive(false);
            }
            if (Burger.isCollected_1 && Burger2.isCollected_2 && Burger3.isCollected_3 && Burger4.isCollected_4)
            {
                game.SetActive(true);
            }
        }
    }
}