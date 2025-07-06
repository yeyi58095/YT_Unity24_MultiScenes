using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTest : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        // two class, scene management and scene loading

        // shift another scene
        // SceneManager.LoadScene(1); // Load scene with index 1 -> it will load and display the scene with index 1 directly
        // SceneManager.LoadScene("MyScene"); //SceneManager.LoadScene("MyScene"); // Load scene with name "MyScene" -> it will load and display the scene with name "MyScene" directly



        // get the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene Name: " + currentScene.name); // Log the name of the current scene
        Scene scene = SceneManager.GetActiveScene();

        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++) {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            Debug.Log("Scene in build index " + i + ": " + path);
        }

        // the scene is loaded
        Debug.Log(scene.isLoaded);

        // the paht of the scene
        Debug.Log("Scene Path: " + scene.path);

        //the index of the scene
        Debug.Log("Scene Build Index: " + scene.buildIndex);

        // the number of root game objects in the scene
        GameObject[] gos = scene.GetRootGameObjects();
        Debug.Log("Number of root game objects in the scene: " + gos.Length);

        // SceneManager class 
        Debug.Log("THe Number of the scene " + SceneManager.sceneCount);


        // the number of the scenes that are loaded
        Debug.Log("The number of loaded scenes: " + SceneManager.sceneCount);

        // create a new scene   
        Scene newScene = SceneManager.CreateScene("NewScene");

        // count the number of scenes are loaded again
        Debug.Log("The number of loaded scenes after creating a new scene: " + SceneManager.sceneCount);

        // unload the scene
        SceneManager.UnloadSceneAsync(newScene);

        // load the scene additively
        SceneManager.LoadScene("MyScene", LoadSceneMode.Additive);
        
    }

    // Update is called once per frame
    void Update() {

    }
}
