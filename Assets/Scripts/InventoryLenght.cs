using System.Security.Cryptography;
using UnityEngine;

public class InventoryLenght : MonoBehaviour
{
    private RectTransform widthHeight;
    private Vector2 parameters;
    private Vector2 actualValue;
    void Start()
    {
        widthHeight = GetComponent<RectTransform>();
        parameters = new Vector2(widthHeight.rect.width, widthHeight.rect.height);

    }

    public void ChangeWidth(float width)
    {
        parameters = new Vector2(parameters.x*width, parameters.y);

        widthHeight.sizeDelta = parameters;
    }
    public void ChangeHeight(float height)
    {
        parameters = new Vector2(parameters.x, parameters.y*height);
        widthHeight.sizeDelta = parameters;
    }
}
