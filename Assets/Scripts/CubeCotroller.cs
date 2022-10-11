using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCotroller : MonoBehaviour
{

    Rigidbody rigidbody;

    public static float speed = 10f;
    public static float distance = 100f;

    float treveledDistance = 0;
    float finishDistance = distance;
    Vector3 lastPos;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, speed);
        lastPos = transform.position;
    }

    private void FixedUpdate()
    {
        treveledDistance += Vector3.Distance(transform.position, lastPos);
        if(treveledDistance >= finishDistance)
        {
            Destroy(transform.gameObject);
        }
        lastPos = transform.position;
    }
}
