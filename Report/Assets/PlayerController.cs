using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D ridgid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    // Use this for initialization
    void Start()
    {
        this.ridgid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //점프한다
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.ridgid2D.AddForce(transform.up * this.jumpForce);
        }

        //좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //플레이어 속도
        float speedx = Mathf.Abs(this.ridgid2D.velocity.x);

        //스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.ridgid2D.AddForce(transform.right * key * this.walkForce);
        }
    }
}