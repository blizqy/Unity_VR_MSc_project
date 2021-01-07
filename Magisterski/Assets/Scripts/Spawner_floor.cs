using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_floor : MonoBehaviour
{
    public GameObject[] cubes_floor;
    public Transform[] points_floor;
    public float beat_floor;
    private float timer_floor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer_floor > beat_floor)
        {
            GameObject cube_floor = Instantiate(cubes_floor[Random.Range(0, 2)], points_floor[Random.Range(0, 4)]);
            cube_floor.transform.localPosition = Vector3.zero;
           // cube_floor.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer_floor -= beat_floor;
        }

        timer_floor += Time.deltaTime;
    }
}
