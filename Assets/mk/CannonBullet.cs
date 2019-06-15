using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CannonBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, 600, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
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
