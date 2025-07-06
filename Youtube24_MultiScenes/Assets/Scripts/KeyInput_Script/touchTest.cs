using UnityEngine;

public class touchTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Input.multiTouchEnabled = true; // Enable multi-touch input
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1) { // Check if there is one touch
            Touch touch = Input.GetTouch(0); // Get the first touch
            Debug.Log("Touch Position: " + touch.position); // Log the touch position

            // Check the phase of the touch and log accordingly
            switch (touch.phase) {
                case TouchPhase.Began:
                    Debug.Log("Touch Began");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Touch Moved");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch Ended");
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Touch Canceled");
                    break;
            }


        }

        if(Input.touchCount > 1) { // Check if there are multiple touches
            for(int i = 0; i < Input.touchCount; i++) {
                Touch touch = Input.GetTouch(i); // Get each touch
                Debug.Log("Touch " + i + " Position: " + touch.position); // Log the position of each touch
            }
        }
    }
}
