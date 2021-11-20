using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _destinations;
    [SerializeField] private NavMeshAgent _agent;

    [SerializeField] private int _destinationIndex;

    [SerializeField] private Options _options;

    void Update()
    {
        _agent.SetDestination(_destinations[_destinationIndex].position);
    }

    public void NextDestionation()
    {
        if (_destinationIndex + 1 < _destinations.Length)
        {
            _destinationIndex += 1;
        }
        else
        {
            _options.ActivateRestartPanel();
        }
    }
}
