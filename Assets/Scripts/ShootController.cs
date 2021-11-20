using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private Animator animator;

    [SerializeField] private Transform _projectileSpawnPosition;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Shoot(RaycastHit hit)
    {
        Vector3 direction = (hit.point - transform.position);
        float angle = Vector3.Angle(direction, transform.forward);

        transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));

        animator.Play("Fire", 0, 0f);

        GameObject projectile = Instantiate(_prefab, _projectileSpawnPosition.position, Quaternion.identity);
        projectile.GetComponent<Projectile>().SetDestination(hit.point);
    }
}
