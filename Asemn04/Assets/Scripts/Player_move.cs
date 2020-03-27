using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(0, 0, 10, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(0, 0, -10);
        }        
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(10, 0, 0);
        }        
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-10, 0, 0);
        }
        
        /*ステージから落ちたときに行う処理*/
        if(transform.position.y < -50){
            //transform.position = new Vector3(0, 4, 0);
            
            /*GameOverのシーンを表示する*/
            SceneManager.LoadScene("GameOverScene"); 
        }
        
    }
    
    void OnCollisionStay(Collision hit){
        if(hit.gameObject.tag == "Enemy"){
            //transform.position = new Vector3 (0, 4, 0);
            
            /*GameOverのシーンを表示する*/
            SceneManager.LoadScene("GameOverScene");
        }
        
        if(hit.gameObject.tag == "Goal"){
            //transform.position = new Vector3 (0, 4, 0);
            /*GameClearのシーンを表示する*/
            SceneManager.LoadScene("ClearScene");
        }
    }
}
