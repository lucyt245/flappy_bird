using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D rigid_body;
    public float flap_strength;
    public logic_manager_script logic;
    public bool bird_alive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_manager_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && bird_alive == true)
        {
            rigid_body.velocity = Vector2.up * flap_strength;
        } 
        else if (transform.position.y < -15 || transform.position.y > 15)
        {
            logic.game_over_function();
            bird_alive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.game_over_function();
        bird_alive = false;
    }
}
