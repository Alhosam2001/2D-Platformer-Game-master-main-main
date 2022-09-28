using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    public Signal signalOn;
    public Signal signalOff;
    private PlayerController thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) < 0.1f)
            {
                waitingToOpen = false;

                doorOpen = true;

                theSR.sprite = doorOpenSprite;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;
                Tomato3LVL2.tomato.GetComponent<SpriteRenderer>().sortingOrder =10;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            signalOn.Raise();
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToOpen = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        signalOff.Raise();
    }
}
