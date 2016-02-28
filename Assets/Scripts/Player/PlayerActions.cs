using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour
{

    public GameObject Laser;
    private float fltFireSpeed = 500f;
    private float fltFireRate = .15f;
    private float fltNextFire = 0;
    private bool blnFire = false;

    void FixedUpdate()
    {
        GameObject instance;

        if (blnFire)
        {
            blnFire = false;
            fltNextFire = Time.time + fltFireRate;
            instance = Instantiate(Laser, transform.position, transform.rotation) as GameObject;
            var boxCollider = instance.AddComponent<BoxCollider2D>();
            boxCollider.isTrigger = true;
            instance.GetComponent<Rigidbody2D>().AddForce(transform.up * fltFireSpeed);
        }
    }

    void OnMouseDrag()
    {
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point.z = gameObject.transform.position.z;
        point.y = gameObject.transform.position.y;
        this.gameObject.transform.position = point;
    }

    void OnMouseDown()
    {
        if (Time.time > fltNextFire)
        {
            blnFire = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" || collider.tag == "EnemyLaser")
        {
            StartCoroutine(GameState.OnDeath());
            //Some animation that shows the player dying. NOT destroy.
            //Destroy(this.gameObject);          
        }
    }

    
}
