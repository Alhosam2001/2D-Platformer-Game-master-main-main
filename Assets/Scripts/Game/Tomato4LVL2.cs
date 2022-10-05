using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato4LVL2 : MonoBehaviour
{
    public static bool isCollected;
    public GameObject game;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.instance.Play("Eat");
        PlayerMovement.isTouched = true;
        isCollected = true;
        Destroy(gameObject);
        AudioManager.instance.Play("EatingTooMuch");
    }
}
