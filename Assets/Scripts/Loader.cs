using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public static class Loader
{

    public enum  Scene
    {
        GameScene,
        Loading,
        MainMenu,
        
    }

    private static Action loaderCallbackAction;

    public static void Load(Scene Loading)
    {

        loaderCallbackAction = () =>
        {
            SceneManager.LoadScene(Loading.ToString());
        };


        // Load Game Scene
        SceneManager.LoadScene(Scene.GameScene.ToString());

    }

    public static void LoaderCallback()
    {
        if (loaderCallbackAction != null)
        {
            loaderCallbackAction();
            loaderCallbackAction = null;
        }
    }
}
