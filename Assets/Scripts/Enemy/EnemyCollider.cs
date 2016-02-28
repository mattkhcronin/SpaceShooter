using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Laser")
        {
            Destroy(this.gameObject);
        }
    }
}
