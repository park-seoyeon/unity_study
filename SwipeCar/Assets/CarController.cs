﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;
    Vector2 startPos;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //스와이프 길이를 구한다.
        if (Input.GetMouseButtonDown(0))
        {
            //마우스 단추를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            //스와이프 길이를 처음 속도로 변경한다.
            this.speed = swipeLength / 500.0f;

            //효과음 재생하기
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
		
	}

    public void stop()
    {
        this.speed = 0;
    }
}
