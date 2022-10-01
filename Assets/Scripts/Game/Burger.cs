using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour
{
    public static GameObject gameObject1;
    public static bool isCollected_1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected_1 = true;
        //Destroy(gameObject);
    }
}
