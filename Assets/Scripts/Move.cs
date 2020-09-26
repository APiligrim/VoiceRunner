using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float backwardsSpeed;
    private Camera cam;


    void Start()
    {
        cam = FindObjectOfType<Camera>();

        if (this.tag == "Box") {
            float scale = Mathf.Round(Random.Range(1.0f, 2.3f));
            transform.localScale = new Vector2(scale, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(backwardsSpeed / 10.0f, 0.0f, 0.0f);

        Vector3 viewPos = cam.WorldToViewportPoint(transform.position);
        

        if (viewPos.x < -1.0f) {
            Destroy(this.gameObject);
        }
        
    }

    
}
