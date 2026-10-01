using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            Vector2 displacement = new Vector2(-speed * Time.deltaTime, 0);
            transform.Translate(displacement);
        } else if (Input.GetKey(KeyCode.D)) {
            Vector2 displacement = new Vector2(speed * Time.deltaTime,0);
            transform.Translate(displacement);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector2 forceToAdd = new Vector2(0, jumpForce);
            rb.AddForce(forceToAdd);
        }
    }
}
