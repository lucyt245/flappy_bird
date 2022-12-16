using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_create_script : MonoBehaviour
{
    public GameObject pipes;
    public float spawn_rate = 4;
    public float height_offset = 6;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        CreatePipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_rate)
        {
            timer += Time.deltaTime;
        } 
        else
        {
            CreatePipe();
            timer = 0;
        }
    }

    void CreatePipe()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowest_point, highest_point), 0), transform.rotation);
    }
}
