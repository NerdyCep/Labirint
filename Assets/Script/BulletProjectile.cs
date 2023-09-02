using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulletRigitbody;

    private void Awake()
    {
        bulletRigitbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        float speed = 40f;
        bulletRigitbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
