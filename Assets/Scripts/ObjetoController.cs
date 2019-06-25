using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoController : MonoBehaviour
{

    private Rigidbody2D body;
    private Vector3 posInicial;

    public float maxDist;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = Vector2.up * velocidade;

        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, posInicial);

        if(dist > maxDist)
        {
            Destroy(gameObject);
        }

    }
}
