using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropScript : MonoBehaviour, IDropHandler
{
    public void OnDrop (PointerEventData eventData) 
    {
        ScriptCard card = eventData.pointerDrag.GetComponent<ScriptCard>();
        if (card)
            card.defaultParent = transform;
    }
}
