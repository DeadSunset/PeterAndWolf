using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropInContainer : MonoBehaviour, IDropHandler
{
    public GameObject place;

    void Start()
    {
        place = (GameObject)this.gameObject;
    }

    public void OnDrop(PointerEventData eventData)
    {
        ScriptCard card = eventData.pointerDrag.GetComponent<ScriptCard>();
        if (card && place.transform.childCount == 0)
            card.defaultParent = transform;
    }
}
