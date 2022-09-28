using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumbGuide : MonoBehaviour
{
    public GameObject game;
    public Button myButton;
    private void Start()
    {
        //myButton.interactable = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            game.SetActive(false);
            //myButton.interactable = true;
        }
    }
}
