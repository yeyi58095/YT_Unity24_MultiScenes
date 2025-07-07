using UnityEngine;

public class collideAndElimiate : MonoBehaviour
{
    // create a prefab about explosion

    public GameObject explosionPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // on collision enter
    private void OnCollisionEnter(Collision collision)
    {
        // create a new explosion object
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        // destroy the current object
        Destroy(gameObject);

        // get the information about the collision
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }

    // presist collision
    private void OnCollisionStay(Collision collision)
    {
      
    }

    // on collision exit
    private void OnCollisionExit(Collision collision)
    {
      
    }
}
