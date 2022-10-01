using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger2 : MonoBehaviour
{
    public static GameObject gameObject1;
    public static bool isCollected_2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected_2 = true;
        //Destroy(gameObject);
    }
}
