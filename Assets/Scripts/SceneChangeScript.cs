using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    //this script is used to change the scenes of the experience
    public void LoadQuizScene()
    {
        SceneManager.LoadScene("2 MiniQuizGame Scene");
    }
    public void LoadTreasureHuntScene()
    {
        SceneManager.LoadScene("3 MiniMemoryGame Scene");
    }
    public void LoadBeachScene()
    {
        SceneManager.LoadScene("4 BeachCleanUp Scene");
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("1 Start Scene");
    }
}
