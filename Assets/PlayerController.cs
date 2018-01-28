using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Animator animator;
    public float delta = 50;
    private Rigidbody2D rb2d;
    public bool death;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ACTIVAR Y DESACTIVAR ANIMACIÓN DE MUERTE
        if (Input.GetKey(KeyCode.T))
        {
            animator.SetBool("Dead", true);
            death = true;
        }
        else if (Input.GetKey(KeyCode.U))
        {
            animator.SetBool("Dead", false);
            death = false;
        }
    }

    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        string px = rb2d.position.x.ToString();
        string py = rb2d.position.y.ToString();
        speed = (float)(speed / delta);
        animator.SetBool("Running", true);
        bool death2 = false;

        //Se determina si el gato tiene le libro y se asignas las respectivas animaciones para cada movimiento
        if (animator.GetBool("TakeBook") == true)
        {
            Debug.Log(animator.GetBool("TakeBook") + "Fuera del metodo");

            //ACTIVAR Y DESACTIVAR ANIMACIÓN DE MUERTE
            if (Input.GetKey(KeyCode.T))
            {
                animator.SetBool("DeadB", true);
                death2 = true;
            }
            else if (Input.GetKey(KeyCode.U))
            {
                animator.SetBool("DeadB", false);
                death2 = false;
            }

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            animator.SetBool("RunningB", true);
            Debug.Log(animator.GetBool("RunningB") + "Fuera del metodo");

            if (death2 == false)
            {
                if (vertical > 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y + speed));
                }
                else if (vertical < 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y - speed));
                }
                if (horizontal > 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x + speed, rb2d.position.y));
                }
                else if (horizontal < 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x - speed, rb2d.position.y));
                }
                else if (horizontal == 0 && vertical == 0)
                {
                    animator.SetBool("RunningB", false);
                }

            }
        }
        else if (death == false)
        {
            if (v > 0)
            {
                rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y + speed));
            }
            else if (v < 0)
            {
                rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y - speed));
            }
            if (h > 0)
            {
                rb2d.MovePosition(new Vector2(rb2d.position.x + speed, rb2d.position.y));
            }
            else if (h < 0)
            {
                rb2d.MovePosition(new Vector2(rb2d.position.x - speed, rb2d.position.y));
            }
            else if (h == 0 && v == 0)
            {
                animator.SetBool("Running", false);
            }

        }
        speed = (float)(speed * delta);

    }

    public void PickBook()
    {
        bool death2 = false;
        animator.SetBool("TakeBook", true);
        Debug.Log("Inside Pick viene el book");
        Debug.Log(animator.name);

        if (animator.GetBool("TakeBook") == true)
        {
            Debug.Log(animator.GetBool("TakeBook"));

            //ACTIVAR Y DESACTIVAR ANIMACIÓN DE MUERTE
            if (Input.GetKey(KeyCode.T))
            {
                animator.SetBool("DeadB", true);
                death2 = true;
            }
            else if (Input.GetKey(KeyCode.U))
            {
                animator.SetBool("DeadB", false);
                death2 = false;
            }

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            animator.SetBool("RunningB", true);
            Debug.Log(animator.GetBool("RunningB") + "AQUIIII");

            if (death2 == false)
            {
                if (vertical > 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y + speed));
                }
                else if (vertical < 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y - speed));
                }
                if (horizontal > 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x + speed, rb2d.position.y));
                }
                else if (horizontal < 0)
                {
                    rb2d.MovePosition(new Vector2(rb2d.position.x - speed, rb2d.position.y));
                }
                else if (horizontal == 0 && vertical == 0)
                {
                    animator.SetBool("RunningB", false);
                }

            }
        }

    }
}
