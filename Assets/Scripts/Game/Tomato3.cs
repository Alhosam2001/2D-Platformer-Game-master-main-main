using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato3 : MonoBehaviour
{
    public static bool isCollected3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement.isTouched = true;
        isCollected3 = true;
        Destroy(gameObject);
    }
}
