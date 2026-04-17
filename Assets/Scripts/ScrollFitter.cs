using UnityEngine;
using UnityEngine.UI;

public class AutoEnableScroll : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform container; 
    public RectTransform viewport;  

    void Update()
    {
        bool shouldScroll = container.rect.height > viewport.rect.height;

        if (scrollRect.vertical != shouldScroll)
        {
            scrollRect.vertical = shouldScroll;
        }
    }
}
