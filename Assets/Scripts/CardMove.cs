using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMove : MonoBehaviour
{
    public GameObject card;
    private Vector3 mousePos;
    bool mouseOverGUI = false;

    void Start()
    {
        card = (GameObject)this.gameObject;
    }

    void Update()
    {
        if (EventSystem.current != null)
        {
            mouseOverGUI = EventSystem.current.IsPointerOverGameObject();
            card.transform.localScale = new Vector3(2.0f, 4.0f, 1.0f);
        }
    }
}
