using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Door : MonoBehaviour
{

    public Signal signalOn;
    public Signal signalOff;
    private PlayerController thePlayer;
    
    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;
    public static bool isWinningLVL1 = false;
    public static bool isWinningLVL2 = false;
    public static bool isWinningLVL3 = false;
    public static bool isAllowdSound = true;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(thePlayer.followingKey.transform.position,transform.position) < 0.1f)
            {
                if (isAllowdSound)
                {
                    AudioManager.instance.Play("putKey");
                    AudioManager.instance.Play("openDoor");
                }
                //AudioManager.instance.Play("putKey");
                waitingToOpen = false;

                doorOpen = true;
                theSR.sprite = doorOpenSprite;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;

            }
        }
        if (doorOpen && Vector3.Distance(thePlayer.transform.position,transform.position)<1f)
        {
            if (isAllowdSound)
            {
                AudioManager.instance.Play("levelWin");
                isAllowdSound = false;
            }
            if (SceneManager.GetActiveScene().name == "Level01")
            {
                isWinningLVL1 = true;
            }
            if (SceneManager.GetActiveScene().name == "Level02")
            {
                isWinningLVL2 = true;
            }
            if (SceneManager.GetActiveScene().name == "Level03")
            {
                isWinningLVL3 = true;
            }
            SceneManager.LoadScene("Transfer");
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