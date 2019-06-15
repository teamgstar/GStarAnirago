using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShadow : MonoBehaviour
{
    //public void Awake(Sprite ShadowSprite)
    //{
    //    this.GetComponent<SpriteRenderer>().sprite = ShadowSprite;
    //}

    // Start is called before the first frame update
    public Vector2 m_Direction;
    public float   m_Speed;
    private GameObject Player;

    private bool b_Destory;

    private PlayerMovement m_PlayerMovement;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        m_PlayerMovement = Player.GetComponent<PlayerMovement>();
        b_Destory = false;
    }

    // Update is called once per frame
    void Update()
    {

        // 플레이어가 움직일땐 계속 따라다니게 하고 만약 멈추면 멈춘 벽까지만 가게 해줌
        if (b_Destory == false)
        {
            m_Direction = Player.transform.position - this.transform.position;
            m_Direction.Normalize();
        }

        this.transform.Translate( m_Direction * Time.deltaTime * m_Speed * GameManager.g_GameSpeed);
        if (Player.GetComponent<PlayerMovement>().m_Rigid.velocity.x <= 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Player.GetComponent<PlayerMovement>().m_Rigid.velocity.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        // 플레이어가 움직임을 멈추면 삭제가 될 수 있게 해줌
        if (Player.GetComponent<PlayerMovement>().m_IsMoving == false)
            b_Destory = true;

        //if (b_Destory && Player.GetComponent<PlayerMovement>().m_IsMoving)
        //    Destroy(this.gameObject);

        //if (Player.GetComponent<PlayerMovement>().m_IsMoving == false)
        //{
        //    Destroy(this.gameObject);
        //
        //}


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // 삭제 될 조건이 맞고, 플레이어나 벽에 닿으면 삭제
        if((collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player") && b_Destory)
        {
            Destroy(this.gameObject);
        }
    }
}
