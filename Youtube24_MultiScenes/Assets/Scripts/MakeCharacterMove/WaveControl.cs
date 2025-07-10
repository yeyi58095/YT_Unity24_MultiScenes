using UnityEngine;

public class WaveControl : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Animator animator;
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            // Trigger the wave animation
            GetComponent<Animator>().SetTrigger("wave");
            // or animator.SetTrigger("wave");
        }


        // for rotation the direction of the character
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical);


        if (dir != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(dir);
            animator.SetBool("IsRun", true);
            transform.Translate(Vector3.forward * Time.deltaTime * 2f);
        } else {
            animator.SetBool("IsRun", false);
        }

       // Debug.Log("Test: " + animator.GetFloat("Test"));
    }

    void LeftFoot() {
        Debug.Log("Left Foot");
    }

    void RightFoot() {
        Debug.Log("Right Foot");
    }
}
