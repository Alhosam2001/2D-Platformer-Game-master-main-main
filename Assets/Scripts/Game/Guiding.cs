using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guiding : MonoBehaviour
{
    public GameObject game;
    public GameObject game2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            game.SetActive(false);
            game2.SetActive(true);
        }
    }
}
