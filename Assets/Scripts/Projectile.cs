using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 _target;

    private Rigidbody _rigidbody;

    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rigidbody.AddForce(_direction * _speed * Time.deltaTime);
    }

    public void SetDestination(Vector3 destination)
    {
        _target = destination;
        _direction = (_target - transform.position).normalized;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.tag == "Block")
        {
            Destroy(gameObject);
        }
    }
}
