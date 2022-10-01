using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger3 : MonoBehaviour
{
    public static GameObject gameObject1;
    public static bool isCollected_3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected_3 = true;
        //Destroy(gameObject);
    }
}
