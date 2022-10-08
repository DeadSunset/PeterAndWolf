using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMove : MonoBehaviour
{
    public GameObject card;
    private Vector3 mousePos;
    private bool mouseOnCard = false;
    private bool cardChoosen = false;
    private int numberChoosenCards;
    private float x, y;

    void Start()
    {
        card = (GameObject)this.gameObject;
        var localPosition = card.transform.localPosition;
        x = localPosition.x;
        y = localPosition.y;
        numberChoosenCards = 0;
    }

    void Update()
    {
        if (mouseOnCard)
        {
            card.transform.localScale = new Vector3(2.0f, 4.0f, 1.0f);
            if (Input.GetMouseButtonDown(0)) // выбор карты при нажатии на ЛКМ
            {
                card.transform.localPosition = new Vector3(0.0f, 2.0f, 0.0f);
                cardChoosen = true;
            }
        }
        else
            card.transform.localScale = new Vector3(1.0f, 2.0f, 1.0f);
        if (Input.GetMouseButtonDown(1)) // отмена выбора карта при нажатии на ПКМ
        {
            card.transform.localPosition = new Vector3(x, y, 1.0f);
            cardChoosen = false;
        }
    }

    void OnMouseEnter()
    {
        mouseOnCard = true;
    }

    void OnMouseExit()
    {
        mouseOnCard = false;
    }
}
