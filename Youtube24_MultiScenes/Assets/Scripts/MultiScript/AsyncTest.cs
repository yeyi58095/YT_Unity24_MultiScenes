using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AsyncTest : MonoBehaviour
{
    AsyncOperation operation;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(loadScene());
    }

    // roroute is to load a scene asynchronously
    IEnumerator loadScene() {
        operation = SceneManager.LoadSceneAsync(1);
        // don't shift the scene immediately after loading finished
        operation.allowSceneActivation = false; // Prevent the scene from activating immediately
        yield return operation;
    }

    float timer = 0f;


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Progress: " + operation.progress); // Log the progress of the scene loading

        timer += Time.deltaTime; 
        if(timer >= 5f) // Wait for 5 seconds before activating the scene
        {
            operation.allowSceneActivation = true; // Activate the scene after 5 seconds
            Debug.Log("Scene activated after 5 seconds.");
        }
    }
}
