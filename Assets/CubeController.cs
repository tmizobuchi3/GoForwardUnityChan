using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //地面の位置★
    private float groundLebel1 = -3.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //★
        if (transform.position.y = -0.3f)
        {
            //着地しているかどうかを調べる★
            bool isGround = (transform.position.y = this.groundLebel1) ? false : true;

            //着地時に音を出す★
            GetComponent<AudioSource>().volume = (isGround) ? 0 : 1;
        }


        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面買いに出たら破棄する
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
}
