using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackScore : MonoBehaviour
{

    private Text text;
    public GameObject player;

    private Player pl;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        pl = player.GetComponent<Player>();       
    }

    // Update is called once per frame
    void Update()
    {
        text.text = pl.score + "";                           
    }
}
