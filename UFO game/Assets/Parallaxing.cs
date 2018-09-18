using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour
{


    public Transform[] backgrounds;

    private float[] scales;

    public float smoothing;

    private Transform cam;

    private Vector3 prevcampos;


    private void Awake()
    {
        cam = Camera.main.transform;
    }
    // Use this for initialization
    void Start()
    {
        prevcampos = cam.position;
        scales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            scales[i] = backgrounds[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float px = (prevcampos.x - cam.position.x) * scales[i];
            float bpx = px + backgrounds[i].position.x;
            Vector3 targetpos = new Vector3(bpx, backgrounds[i].position.y, backgrounds[i].position.z
              );
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, targetpos, smoothing * Time.deltaTime);

        }
        prevcampos = cam.position;
    }
}
