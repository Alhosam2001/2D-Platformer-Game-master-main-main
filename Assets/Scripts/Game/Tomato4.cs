using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato4 : MonoBehaviour
{
    public static bool isCollected4;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement.isTouched = true;
        isCollected4 = true;
        Destroy(gameObject);
    }
}
