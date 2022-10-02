using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeHealther : MonoBehaviour
{
    public GameObject heal;
    public static int enterCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerMovement.Healther = true;
            enterCount++;
            if (enterCount == 5)
            {
                heal.SetActive(false);
            }
        }
    }
}
