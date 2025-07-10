using UnityEngine;

public class AnimatorTest : MonoBehaviour {
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        // get the animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0)) {
            animator.Play("animatorLeft");
        }
    }
}
