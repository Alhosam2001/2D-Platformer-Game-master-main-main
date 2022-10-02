using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato3LVL2 : MonoBehaviour
{
    public static SpriteRenderer tomato;
    public static bool isCollected;
    public static bool isAllowdSound = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            AudioManager.instance.Play("Eat");
            isAllowdSound = false;
        }
        PlayerMovement.isTouched = true;
        isCollected = true;
        Destroy(gameObject);
    }
}
