using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public float g_GameSpeed = 1f;

    static public void SetGameSpeed(float Speed)
    { 
            g_GameSpeed = Speed;

        Object[] obj = Object.FindSceneObjectsOfType(typeof(GameObject));

        foreach (GameObject iter in obj)
        {
            if (iter.GetComponent<Rigidbody2D>() != null)
            {
              //  iter.GetComponent<Rigidbody2D>().gravityScale = 0f;
                iter.GetComponent<Rigidbody2D>().velocity *= Speed;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
