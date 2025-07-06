using UnityEngine;

public class VirtualAxis : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Get the horizontal axis input
        float vertical = Input.GetAxis("Vertical"); // Get the vertical axis input

        Debug.Log(horizontal + ", " + vertical );    
         
    }
}
