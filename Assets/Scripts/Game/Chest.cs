using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    public Signal signalOn;
    public Signal signalOff;
    private PlayerController thePlayer;
    public GameObject gameO;
    public GameObject game;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;
    public static bool isAllowdSound = true;
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
                if (isAllowdSound)
                {
                    AudioManager.instance.Play("putKey");
                    AudioManager.instance.Play("openDoor");
                    isAllowdSound = false;
                }
                waitingToOpen = false;

                doorOpen = true;
                game.SetActive(false);
                theSR.sprite = doorOpenSprite;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;
                gameO.SetActive(true);
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
