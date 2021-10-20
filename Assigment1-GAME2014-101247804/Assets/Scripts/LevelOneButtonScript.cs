using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneButtonScript : MonoBehaviour
{
    public void OnLevelOnesButtonPressed()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
