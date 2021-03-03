using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject hpGage;
    GameObject point;
    float p = 0;

    // Use this for initialization
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
        this.point = GameObject.Find("point");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void IncreasePoint()
    {
        this.point.GetComponent<Text>().text = "point : " + (p+=1).ToString();
    }
}
