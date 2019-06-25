using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorMeteoros : MonoBehaviour
{
    public GameObject meteoro;

    private float xMin;
    private float xMax;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D limite = GameObject.FindWithTag("LimiteTela").GetComponent<BoxCollider2D>();

        xMin = limite.bounds.min.x;
        xMax = limite.bounds.max.x;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if(timer > 1.5)
        {
            float pX = Random.Range(xMin, xMax);

            GameObject m = Instantiate(meteoro);
            m.transform.position = new Vector3(pX, transform.position.y, 0);

            timer = 0;
        }
    }
}
