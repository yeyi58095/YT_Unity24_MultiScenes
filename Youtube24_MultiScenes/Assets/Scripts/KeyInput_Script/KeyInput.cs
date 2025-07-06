using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 0 for left mouse button, 1 for right mouse button, 2 for middle mouse button
        {
            Debug.Log("Mouse Button Pressed");
        }

        if (Input.GetMouseButton(0)) {
            Debug.Log("Mouse Button Held Down");
        }

        if(Input.GetMouseButtonUp(0)) {
            Debug.Log("Mouse Button Released");
        }

        // Press the keyboard key

        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("Key A Pressed");
        }

        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("Key A Held Down");
        }

        if(Input.GetKeyUp(KeyCode.A)) {
            Debug.Log("Key A Released");
        }
    }
}
