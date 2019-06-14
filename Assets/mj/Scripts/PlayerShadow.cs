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
    private int Col;
    private GameObject Player;

    void Start()
    {
        Col = 0;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        m_Direction =  Player.transform.position - this.transform.position;
        m_Direction.Normalize();

        this.transform.Translate( m_Direction * Time.deltaTime * m_Speed * GameManager.g_GameSpeed);
        if (Player.GetComponent<PlayerMovement>().m_Rigid.velocity.x <= 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Player.GetComponent<PlayerMovement>().m_Rigid.velocity.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Player.GetComponent<PlayerMovement>().m_IsMoving == false)
        {
            Destroy(this.gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Player")
        //{

        //    if (Col < 1) { Col++; }
        //    else
        //    {
        //        Destroy(this.gameObject);
        //        Debug.Log("col");
        //    }
        //}
    }
}
