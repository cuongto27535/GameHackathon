using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private BoxCollider2D boxCollider2D;
    public GameObject bullet;
    private DirectionControl directionControl;
    private DirectionControlBoom directionControlBoom1;
    public GameObject explodingBoom;
    public float traiPhai;
    public float lenXuong;
    public bool isFacingRight = true;
    public int tocDo = 4;
    private Vector3 originalScale;
    void Start()
    {
        originalScale = transform.localScale;
        directionControl = bullet.GetComponent<DirectionControl>();
        directionControlBoom1 = explodingBoom.GetComponent<DirectionControlBoom>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Attack();
        BoostSpeed();
    }

    public void Movement()
    {
        traiPhai = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(tocDo * traiPhai, rb.velocity.y);

        if (isFacingRight == true && traiPhai == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;


            directionControl.direction = Vector3.left;
        }
        else if (isFacingRight == false && traiPhai == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;


            directionControl.direction = Vector3.right;
        }

        lenXuong = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0f, lenXuong, 0f) * tocDo * Time.deltaTime;
        transform.Translate(movement);

    }

    public void Attack()
    {
        if (Input.GetKey(KeyCode.J))
        {
            // Bắn
            Debug.Log("Fireeeeeeeeeeeeeeee");
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            // Ném bom
            Debug.Log("Booooooommmm");
            Instantiate(explodingBoom, transform.position, Quaternion.identity);
        }
    }

    public void BoostSpeed()
    {
        if (Input.GetKey(KeyCode.I))
        {
            tocDo = 6;
        }
    }
}
