using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] levels;
    private void Start()
    {
        int LevelReached = PlayerPrefs.GetInt("LevelReached", 1);
        for(int i = 0; i < levels.Length; i++)
        {
            if ((i + 1) > LevelReached)
            {
                levels[i].interactable = false;
            }
        }
    }
    public void Select(int NumberinBuild)
    {
        SceneManager.LoadScene(NumberinBuild);
    }
}
