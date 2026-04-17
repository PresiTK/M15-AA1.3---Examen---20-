using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FirstPersonController))]
public class FirstPersonController_Input : MonoBehaviour
{
    FirstPersonController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<FirstPersonController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        Vector2 move = InputManager.Instance.inputs.Default.Move.ReadValue<Vector2>();
        controller.Move(move, Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        Vector2 look = InputManager.Instance.inputs.Default.Look.ReadValue<Vector2>();
        controller.Look(look);
    }
}
