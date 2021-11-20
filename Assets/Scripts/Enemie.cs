using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    private WayPoint _wayPoint;

    public void SetWayPoint(WayPoint wp)
    {
        _wayPoint = wp;
    }

    private void OnDestroy()
    {
        _wayPoint.RemoveFromList(gameObject);
    }
}
