using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    private float _moveSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        var point = this.gameObject.transform.position;
        point.y = gameObject.transform.position.y - (_moveSpeed * Time.deltaTime);
        this.gameObject.transform.position = point;
    }
}
