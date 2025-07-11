using Unity.Mathematics;
using UnityEngine;

public class WaveControl : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public Transform target;
    private Animator animator;
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        /*if (Input.GetKeyDown(KeyCode.F)) {
            // Trigger the wave animation
            GetComponent<Animator>().SetTrigger("wave");
            // or animator.SetTrigger("wave");
        }*/


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

    //  public Transform  target; 
    // IK related
    private void OnAnimatorIK(int layerIndex) {
        // set the head ik
        animator.SetLookAtWeight(1);
        animator.SetLookAtPosition(target.position);

        // set the weight belonging position of the  right hand IK
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        // rotation
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        // set the right IK
        animator.SetIKPosition(AvatarIKGoal.RightHand, target.position);
        
        animator.SetIKRotation(AvatarIKGoal.RightHand, target.rotation);
    }
}
