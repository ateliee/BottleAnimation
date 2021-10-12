using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class BottleCtrl : MonoBehaviour
{
    [SerializeField, Range(0, 1)]
    public float value = 0.0f;

    [SerializeField] private Image waterImage;
    
    // Update is called once per frame
    void Update()
    {
        if (!waterImage)
        {
            return;
        }
        var size = waterImage.rectTransform.rect.size;
        var pos = waterImage.rectTransform.anchoredPosition;
        pos.y = (size.y * (-1 + value));
        waterImage.rectTransform.anchoredPosition = pos;
    }
}
