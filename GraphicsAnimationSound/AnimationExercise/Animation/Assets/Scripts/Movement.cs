using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField]
    float rotationalSpeed;

    [SerializeField]
    float moveSpeed;

    private float vertical;
    private float horizontal;
    private bool jump;
    private Animator anim;
    private Rigidbody rb;
    private bool grounded;

    private void Awake() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");
    }

    private void FixedUpdate() {
        anim.SetFloat("Speed", vertical);

        if (jump && !anim.GetCurrentAnimatorStateInfo(0).IsName("BaseLayer.Jump")) {
            anim.SetTrigger("Jump");
        }

        rb.MovePosition(transform.position + transform.forward * vertical * moveSpeed * 0.01f);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
    }
}
