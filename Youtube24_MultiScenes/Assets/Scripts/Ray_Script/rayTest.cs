using UnityEngine;

public class rayTest : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        // Example of using a ray
        // Just emit a ray  
        // Ray ray = new Ray(Vectorer3.zero, Vector3.up);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) // Check if the left mouse button is pressed
        {
            // Method 2
            // Emit a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // declare a variable to store the hit information
            RaycastHit hit;
            // Check if the ray hits an object
            bool res = Physics.Raycast(ray, out hit);  // out is a c# keyword that allows the method to return multiple values
                                                       // if the ray hits an object, 'hit' will contain the hit information

            if (res) {
                Debug.Log("Hit object position: " + hit.point);

                transform.position = hit.point + new Vector3(0, transform.localScale.y / 2f, 0);
            }

            // multiple ways to use raycast
            // RaycastHit[] hits = Physics.RaycastAll(ray, 100, 1 << 10); // Get all objects hit by the ray, 100 means the max distance of the ray, 1 << 10 means the layer mask (in this case, only objects in layer 10 will be hit)
        }

    }
}
