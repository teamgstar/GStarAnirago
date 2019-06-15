using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CannonBullet : MonoBehaviour
{
    private float y = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        this.GetComponent<Rigidbody2D>().MovePosition((Vector2)this.transform.position + (new Vector2(1,1 + y) * GameManager.g_GameSpeed * Time.fixedDeltaTime));
        y -= 0.02f;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
        else if (collision.gameObject.tag == "Shadow")
        {

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
