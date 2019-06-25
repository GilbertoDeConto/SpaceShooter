using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{

    public GameObject explosao;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Meteoro"))
        {
            Instantiate(explosao, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
