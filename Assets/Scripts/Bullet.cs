using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Update()
    {
        Destroy(this.gameObject,5);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mummy")) 
        {
            Destroy(this.gameObject);
        }
    }
}
