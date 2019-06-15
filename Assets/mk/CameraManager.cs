using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraManager : MonoBehaviour
{
    public GameObject   m_Player;
    [HideInInspector] public Vector2      m_DifferenceVector;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = m_Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // this.transform.position = 
        Vector3 NewPos;

        NewPos = Vector3.Lerp(new Vector3 (this.transform.position.x, this.transform.position.y,-10f), new Vector3(m_Player.transform.position.x, m_Player.transform.position.y, -10f ),Time.fixedDeltaTime * 2.5f);
        m_DifferenceVector = this.transform.position - NewPos;

        this.transform.position = NewPos;

    }
}
