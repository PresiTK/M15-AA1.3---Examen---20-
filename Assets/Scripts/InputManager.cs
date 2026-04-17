using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    public  InputMap inputs { get; private set; }
    private void Awake()
    {
        Instance = this;

        inputs = new InputMap();
        inputs.Enable();
        inputs.Default.Enable();
    }

}
