using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           if(Input.GetMouseButtonDown(0)) // Check if the left mouse button is pressed
           {
               // Play the animation
               GetComponent<Animation>().Play("Left");
        }
    }
}
