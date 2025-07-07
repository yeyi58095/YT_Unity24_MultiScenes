using UnityEngine;

public class TriggerControl : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other) {  // if Collision -> void OnCollisionEnter(Collision collision)  -> parameter is different    
        GameObject wall = GameObject.Find("Wall");
        if (wall != null) {
            wall.SetActive(false);  // Disable the wall GameObject
        }
    }
    private void OnTriggerStay(Collider other) {

    }
    private void OnTriggerExit(Collider other) {

    }
}
