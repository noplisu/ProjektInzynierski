using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
    public void mainMenu()
    {
        Application.LoadLevel(0);
    }

    public void luk()
    {
        Application.LoadLevel(1);
    }

    public void parkowanieRownolegle()
    {
        Application.LoadLevel(2);
    }

    public void parkowanieProstopadle()
    {
        Application.LoadLevel(3);
    }

    public void reload()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }

    public void exit()
    {
        Application.Quit();
    }
}
