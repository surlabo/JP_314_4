using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public float jumpForce;

    private Rigidbody rb;

    private bool canJump = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {   
            rb.AddForce(0, jumpForce, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            jumpForce = 500;
        }
        if (collision.gameObject.CompareTag("Ground_2"))
        {
            canJump = true;
            jumpForce = 1000;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }
        if (collision.gameObject.CompareTag("Ground_2"))
        {
            canJump = false;
        }
    }
}
