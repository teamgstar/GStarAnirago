using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float m_MaxHp;
    protected float m_CurHp;
    protected virtual void Init(float Maxhp)
    {
        m_MaxHp = Maxhp;
        m_CurHp = Maxhp;
        this.Start();
    }
    // Start is called before the first frame update
    public virtual void Start()
    {
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if(m_CurHp < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
