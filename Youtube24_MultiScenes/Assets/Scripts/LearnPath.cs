using UnityEngine;

public class LearnPath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // the path to this script in the Unity Editor (read-only, zipped with confident)
        Debug.Log("Path to this script: " + Application.dataPath);

        // the path to the persistent data directory (read-write, not zipped with confident)
        Debug.Log("Persistent data path: " + Application.persistentDataPath);

        // StreamingAssets path (read-only, not zipped with confident)
        Debug.Log("StreamingAssets path: " + Application.streamingAssetsPath);

        // Temporary cache path (read-write, not zipped with confident)
        Debug.Log("Temporary cache path: " + Application.temporaryCachePath);

        // check it is operating in the background
        Debug.Log("Is running in background: " + Application.runInBackground);

        // open the URL in the default web browser
        Debug.Log("Opening URL: https://www.unity3d.com");
        Application.OpenURL("https://www.unity3d.com");

        // quit the application (only works in built applications, not in the editor)
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
