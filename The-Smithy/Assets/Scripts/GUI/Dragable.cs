using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("Dragable")]
public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public void OnBeginDrag(PointerEventData eventData) {
        GameObject m_icon = new GameObject("icon");
        Image image= m_icon.AddComponent<Image>();

        image.sprite = GetComponentInParent<Image>().sprite;
        image.SetNativeSize();
        m_icon.transform.SetAsLastSibling();

        Transform parent = GameObject.FindGameObjectWithTag("MainCanvas").transform as Transform;
        m_icon.transform.SetParent(parent);

    }

    public void OnDrag(PointerEventData eventData) {
        
    }

    public void OnEndDrag(PointerEventData eventData) {
        throw new System.NotImplementedException();
    }
}
