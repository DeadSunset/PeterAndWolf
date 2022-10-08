using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject place1, place2, button;

    void Start()
    {
        //button = (GameObject)this.gameObject;
        button.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void FixedUpdate()
    {
        if (place1.transform.childCount == 1 && place2.transform.childCount == 1)
            button.SetActive(true);
    }
}
