using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TheSmithy.Data;

public class mixDropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Image containerImage;
    public Image receivingImage;
    public container receivingContainer;
    private Color normalColor;
    public Color highlightColor = Color.yellow;

    public void OnEnable()
    {
        if (containerImage != null)
            normalColor = containerImage.color;
    }

    public void OnDrop(PointerEventData data)
    {
        //receivingContainer.Contains = data.pointerDrag.GetComponent<container>().Contains;
        // receivingContainer.Set_image();
        containerImage.color = normalColor;


        if (receivingImage == null)
            return;

        container dropContainer = GetContainer(data);
        if (dropContainer != null)
        {
            receivingContainer.Contains = dropContainer.Contains;
            receivingContainer.Set_image();
            Debug.Log(receivingContainer.Contains.name);
        }

    }

    public void OnPointerEnter(PointerEventData data)
    {
        if (containerImage == null)
            return;

        container dropContainer = GetContainer(data);
        if (dropContainer != null)
            containerImage.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData data)
    {
        if (containerImage == null)
            return;

        containerImage.color = normalColor;
    }

    private container GetContainer(PointerEventData data)
    {
        var originalObj = data.pointerDrag;
        if (originalObj == null)
            return null;

        var dragMe = originalObj.GetComponent<DragMe>();
        if (dragMe == null)
            return null;

        var srcImage = originalObj.GetComponent<Image>();
        if (srcImage == null)
            return null;

        var conTainer = originalObj.GetComponent<container>();

        return conTainer;
    }

}
