using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform mira;
    public GameObject laser;

    private Rigidbody2D body;

    private float direcao;

    private float xMin;
    private float xMax;

    public GameObject explosao;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        BoxCollider2D limite = GameObject.FindWithTag("LimiteTela").GetComponent<BoxCollider2D>();

        xMin = limite.bounds.min.x;
        xMax = limite.bounds.max.x;
    }

    // Update is called once per frame
    void Update()
    {
        direcao = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, mira.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(400 * direcao * Time.deltaTime, 0);

        float pX = Mathf.Clamp(transform.position.x, xMin, xMax);
        transform.position = new Vector3(pX, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteoro"))
        {
            Instantiate(explosao, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
