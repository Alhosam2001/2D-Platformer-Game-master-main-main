using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrainingLevel : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("Training");
    }
}
