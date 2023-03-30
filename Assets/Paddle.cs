using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "rightPaddle")
        {
            movePaddle(gameObject.name);
        }
        else if(gameObject.name == "leftPaddle")
        {
            movePaddle(gameObject.name);
        }
    }

    void movePaddle(string PaddleName)
    {
        float moveY = Input.GetAxisRaw(PaddleName) * speed * Time.deltaTime;
        transform.position = new Vector2(
            transform.position.x,
            Mathf.Clamp(transform.position.y + moveY,minY, maxY));
    }
}
