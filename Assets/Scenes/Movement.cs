 using UnityEngine;
 using System.Collections;
 
public class Movement : MonoBehaviour {
    public float speed;
    public float jump;
    float moveVelocity;
    public float jumpforce;
    private bool isGrounded;
    private Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update () {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.AddForce(Vector3.up * jumpforce,ForceMode2D.Impulse);
        };

        moveVelocity = 0;
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
            moveVelocity = -speed;
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
            moveVelocity = speed;
        }
        rb.velocity = new Vector2 (moveVelocity, rb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D col) {   
        if(col.gameObject.layer == 3) {
            isGrounded = true;
        }
        if(col.gameObject.layer == 7) {
            Destroy(col.gameObject);
        }
    }
    void OnCollisionExit2D(Collision2D col) {
        if (col.gameObject.layer == 3) {
            isGrounded = false;
        }
    }
}