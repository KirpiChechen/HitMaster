using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private ShootController _shootController;

    public Vector3 MousePosition { get; private set; }

    private void Start()
    {
        _shootController = GetComponent<ShootController>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out hit))
        {
            _shootController.Shoot(hit);
        }
        
    }
}
