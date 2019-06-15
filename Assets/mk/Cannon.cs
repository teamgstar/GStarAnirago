using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : Enemy
{
    public GameObject Bullet;
    private List<GameObject> m_listBullet;
    // Start is called before the first frame update
    public new void Start()
    {
        // 여기서 Start도 호출해줌
        m_listBullet = new List<GameObject>();
        Init(5);
        StartCoroutine(FireBullet());

    }

    // Update is called once per frame
    public new void Update()
    {
        base.Update();
        //Debug.Log("자식");
        ////Collider[] colls = Physics.OverlapSphere(transform.position, 10.0f);
        //// 왼쪽보고있으면
        //if (this.transform.rotation.z >= 90f)
        //{ 

        //}
        //// 오른쪽보고있으면
        //else
        //{

        //}
        //  GetComponent<BoxCollider2D>().IsTouchingLayers("zz");

    }

        IEnumerator FireBullet()
    {
        while (true)
        {
            GameObject obj = Bullet;
            obj.transform.position = this.transform.position;
            obj.transform.Translate(new Vector2(1, 2));
            Object.Instantiate(obj);
            m_listBullet.Add(Bullet);
            yield return new WaitForSeconds(5f);
        }
    }
}
