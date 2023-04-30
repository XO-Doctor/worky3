using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public CanvasGroup holder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Cursor.visible = false;
        holder.alpha = 0;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Cursor.visible = true;
        holder.alpha = 1;
    }
}
