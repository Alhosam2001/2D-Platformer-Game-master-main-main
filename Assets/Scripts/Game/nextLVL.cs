using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class nextLVL : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("Level01");
    }
}
