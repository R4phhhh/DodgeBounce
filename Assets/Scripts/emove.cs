using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        var offset = 90f;
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
        Vector3 rot = transform.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y, rot.z-180);
        transform.rotation = Quaternion.Euler(rot);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * 4f;
        Destroy(gameObject, 25);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 1)
        {
            Vector3 normal = collision.contacts[0].normal;
            transform.up = Vector2.Reflect(transform.up, normal);
        }
    }
}
