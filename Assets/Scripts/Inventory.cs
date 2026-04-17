using UnityEngine;
using UnityEngine.Windows;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;


    private void Update()
    {
        if (InputManager.Instance.inputs.Default.Inventory.WasCompletedThisFrame())
        {
            Debug.Log("JAJAJA");
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}
