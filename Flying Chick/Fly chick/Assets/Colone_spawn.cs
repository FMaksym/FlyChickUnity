using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colone_spawn : MonoBehaviour
{
    public float maxTime = 2.3f;
    private float timer = 0;
    public GameObject Pipe;
    public float height = 2.2f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(Pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
