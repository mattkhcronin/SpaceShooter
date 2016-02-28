using UnityEngine;
using System.Collections;

public class CeilingCollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Laser")
        {
            Destroy(collider.gameObject);
        }
    }

}
