using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainScreenUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoQuestScene()
    {
        SceneManager.GotoScene(1);
    }
    public void GotoCharacterScene()
    {
        SceneManager.GotoScene(2);
    }
}
