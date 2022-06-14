using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager
{

    public static void GotoScene(int index)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }

}
