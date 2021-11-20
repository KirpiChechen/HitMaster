using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WayPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemiesArray;
    private List<GameObject> enemies = new List<GameObject>();

    private PlayerMovement _playerMovement;

    private void Start()
    {
        _playerMovement = FindObjectOfType<PlayerMovement>();

        enemies = _enemiesArray.OfType<GameObject>().ToList();

        SetWayPoint();
    }

    private void Update()
    {
        if (enemies.Count == 0)
        {
            _playerMovement.NextDestionation();
            gameObject.SetActive(false);
        }
    }

    private void SetWayPoint()
    {
        foreach (GameObject gobject in enemies)
        {
            gobject.GetComponent<Enemie>().SetWayPoint(this);
        }
    }

    public void RemoveFromList(GameObject enemie)
    {
        enemies.Remove(enemie);
    }
}
