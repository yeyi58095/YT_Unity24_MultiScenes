using UnityEngine;

public class transformTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the position 
        Debug.Log("Position: " + transform.position);
        Debug.Log("Local Position: " + transform.localPosition);

        // the relative position to the parent object and the child object

        // get the parnt object
        GameObject parentTransform = transform.parent.gameObject;

        // get the number of the child objects
        int childCount = transform.childCount;

        // detch the relative position to the child object
        // transform.DetachChildren(); // Detach all child objects from this transform

        // get the child object

        //method 1
        Transform trans = transform.Find("Child"); // Find a child object by name  

        //method 2
        trans = transform.GetChild(0); // Get the first child object

        // determine whether this object is the child object of another object
        bool res = trans.IsChildOf(transform); // Check if this transform is a child of the specified transform 

        // estiblish the relationship between the parent and child objects
        trans.SetParent(transform); // Set this transform as the parent of the specified transform


    }

    // Update is called once per frame
    void Update()
    {
        // look at the origin, presistly
        //transform.LookAt(Vector3.zero); // Make the object look at the origin (0,0,0)

        // tate the object around its local Y axis
        //transform.Rotate(Vector3.up, 20 * Time.deltaTime); // Rotate the object around its local Y axis at 20 degrees per second

        // rotate the object around some object
        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime); // Rotate the object around the origin (0,0,0) at 20 degrees per second
    }
}
