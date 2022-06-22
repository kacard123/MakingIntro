using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStory : MonoBehaviour
{
    
    void OnEnable()
    {
        // Only specifying the sceneName or SceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Main_Room_01",LoadSceneMode.Single);   
    }
}
