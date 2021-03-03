using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube2Click : MonoBehaviour
{
    public GameObject cube2;
    public Image imgCat;

    void Start()
    {
        imgCat.gameObject.SetActive(false);
    }
    void OnMouseUp()
    {
        GetComponent<AudioSource>().Play();
        imgCat.gameObject.SetActive(true);
    }
}
