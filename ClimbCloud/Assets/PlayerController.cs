using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody2D ridgid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        this.ridgid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //점프한다
        if (Input.GetKeyDown(KeyCode.Space) && this.ridgid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.ridgid2D.AddForce(transform.up * this.jumpForce);
            GetComponent<AudioSource>().Play();
        }

        //좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //플레이어 속도
        float speedx = Mathf.Abs(this.ridgid2D.velocity.x);

        //스피드 제한
        if(speedx < this.maxWalkSpeed)
        {
            this.ridgid2D.AddForce(transform.right * key * this.walkForce);
        }

        //움직이는 방향에 따라 이미지 반전
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //플레이어의 속도에 맞춰 애니메이션 속도를 바꾼다
        if(this.ridgid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        //플레이어가 화면 밖으로 나갔다면 처음부터
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    //골 도착
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("골");
        SceneManager.LoadScene("ClearScene");
    }
}
