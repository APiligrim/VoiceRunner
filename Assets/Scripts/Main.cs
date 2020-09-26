using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject box, collectible;
    public float firstX;
    
    public float frequency;
    
    private float timer;

    private Camera cam;    

    // Start is called before the first frame update
    void Start()
    {
        timer = frequency;
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0.0f)
        {
            Vector3 vwCoords = cam.ViewportToWorldPoint(new Vector3(1.2f, 0.15f, 1.0f));
            Instantiate(box, vwCoords, Quaternion.identity);

            vwCoords.x += 0.2f;
            vwCoords.y += 1.0f;
            Instantiate(collectible, vwCoords, Quaternion.identity);

            timer = frequency;
        }

        
    }
}
