using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMove : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    private Vector3 mousePos;

    void Start()
    {
        player = (GameObject)this.gameObject;
    }

    void FixedUpdate()
    {
        var localPosition = player.transform.localPosition;
        var x = localPosition.x + 4;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mX = mousePos.x;
        var mY = mousePos.y;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || (Input.GetMouseButton(0) && mX - x >= 0 && mY > 0)) // движение персонажей вправо (клавиши D, стрелка вправо и нажатие ЛКМ в правой части экрана)
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || (Input.GetMouseButton(0) && mX - x < 0 && mY > 0)) // движение персонажей вправо (клавиши A, стрелка влево и нажатие ЛКМ в левой части экрана)
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
    }
}
