using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenLevelsList()
    {
        SceneManager.LoadScene(1);
    }
}
