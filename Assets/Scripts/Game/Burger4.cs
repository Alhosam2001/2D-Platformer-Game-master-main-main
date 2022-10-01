using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger4 : MonoBehaviour
{
    public static GameObject gameObject1;
    public static bool isCollected_4;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected_4 = true;
        //Destroy(gameObject);
    }
}