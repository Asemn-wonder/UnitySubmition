using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1_move : MonoBehaviour
{

    private Vector3 EnemyPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyPosition = new Vector3(0.0f, 20.0f, 12.0f);
        this.transform.position = EnemyPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 0.5f){
            this.transform.Translate(0, -0.1f, 0);
        }
    }
}
