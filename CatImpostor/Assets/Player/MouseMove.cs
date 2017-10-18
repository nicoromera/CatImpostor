using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseMove : MonoBehaviour
{
    

    Rigidbody2D rb;
    bool isDropped;
    Vector3 targetPos;
    Vector2 aux;



    void Awake()
    {
        isDropped = false;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (!isDropped)
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            aux = Vector2.Lerp(transform.position, targetPos, 0.2f);

            transform.position = new Vector2(Mathf.Clamp(aux.x, -3, 3), transform.position.y);

            if (Input.GetMouseButtonDown(0))
            {
                isDropped = true;
                rb.gravityScale = 1;
            }

        }

       

    }

    

}







    





