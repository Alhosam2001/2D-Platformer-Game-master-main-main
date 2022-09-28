using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoLVL2 : MonoBehaviour
{
    public static bool isCollected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement.isTouched = true;
        isCollected = true;
        Destroy(gameObject);
    }
}
