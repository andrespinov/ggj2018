using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    public float speed = 2f;
    public float maxSpeed = 3f;
    private Rigidbody2D rb3d;

    // Use this for initialization
    void Start()
    {
        rb3d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        //
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        string px = rb3d.position.x.ToString();
        string py = rb3d.position.y.ToString();
        bool bx = false;
        bool by = false;

        if (px.Length > 2 && px.Substring(px.Length - 2).Equals(".5"))
        {
            bx = true;
        }
        if (py.Length > 2 && py.Substring(py.Length - 2).Equals(".5"))
        {
            by = true;
        }

       // if (bx)
        //{
            if (v > 0)
            {
                rb3d.MovePosition(new Vector2(rb3d.position.x, rb3d.position.y + 0.25f));
            }
            else if (v < 0)
            {
                rb3d.MovePosition(new Vector2(rb3d.position.x, rb3d.position.y - 0.25f));
            }
        //}
        //if (by)
        //{
            if (h > 0)
            {
                rb3d.MovePosition(new Vector2(rb3d.position.x + 0.25f, rb3d.position.y));
            }
            else if (h < 0)
            {
                rb3d.MovePosition(new Vector2(rb3d.position.x - 0.25f, rb3d.position.y));
            }
        //}
    }
}

