using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class EditorUtils
{
    static string keyResoreScenePath;
    static string keyNeedRestore;
    static EditorUtils()
    {
        EditorApplication.update += Update;

        keyResoreScenePath = Application.dataPath + "resoreScenePath";
        keyNeedRestore = Application.dataPath + "needRestore";
    }

    static void Update()
    {
        if (!EditorApplication.isPlaying && 
            !EditorApplication.isPlayingOrWillChangePlaymode && 
            PlayerPrefs.GetInt(keyNeedRestore) == 1)
        {
            PlayerPrefs.SetInt(keyNeedRestore, 0);
            EditorSceneManager.OpenScene(PlayerPrefs.GetString(keyResoreScenePath));
        }
    }

    [MenuItem("Prototype/Run Game")]
    
    public static void RunGame()
    {
        if (!EditorApplication.isPlaying)
        {
            PlayerPrefs.SetString(keyResoreScenePath, EditorSceneManager.GetActiveScene().path);
            EditorSceneManager.SaveOpenScenes();
            EditorSceneManager.OpenScene(EditorBuildSettings.scenes[0].path);
            PlayerPrefs.SetInt(keyNeedRestore, 1);
            EditorApplication.isPlaying = true;
        }
    }
}
