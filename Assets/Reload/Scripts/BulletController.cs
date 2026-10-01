using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody2D bullet;
    public float moveSpeed;
    public SpriteRenderer sprite;
    
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {   
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontal,vertical, 0);
        direction = direction.normalized * moveSpeed * Time.deltaTime;

        if (!Input.anyKey) {
            return;
        }
        bullet.transform.position += direction;

    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Collided!");
        sprite.enabled = false;
        animator.SetTrigger("Shoot");
        MinigameManager.MinigameSuccess();
    }
}
