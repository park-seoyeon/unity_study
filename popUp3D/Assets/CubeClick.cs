using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeClick : MonoBehaviour
{
    public GameObject cube;
    public Image imgHeart;

    void Start()
    {
        imgHeart.gameObject.SetActive(false);    
    }
    void OnMouseUp()
    {
        GetComponent<AudioSource>().Play();
        imgHeart.gameObject.SetActive(true);
    }

}
