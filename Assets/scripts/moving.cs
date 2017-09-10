using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {
    public Material fireball;
    public Vector2 pos;
    private float speed=9;
    GameObject g;
    GameObject ball;
    public bool fireon = false;
    public bool flipon = false;
    public bool slowon = false;
    public bool faston = false;
    GameObject ptext;
	void Start ()
    {
        pos = transform.position;
	}
	
	void Update ()
    {
        if (slowon == true)
            speed = 4;
        else if (faston == true)
            speed = 18;
        else
            speed = 9;
        float move = Input.GetAxis("Horizontal");
        if (flipon == false)
            pos.x += move * Time.deltaTime * speed;
        else
            pos.x -= move * Time.deltaTime * speed;
        pos.x = Mathf.Clamp(pos.x,-7.6f,7.6f);
        transform.position = pos;
        g = GameObject.Find("bottom");
        ball = GameObject.FindGameObjectWithTag("ball");
        ptext = GameObject.Find("Points2");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        
        if (col.gameObject.name == "health")
        {
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points + 5;
            g.GetComponent<trigger>().healthcount++;
            g.GetComponent<trigger>().t.text = g.GetComponent<trigger>().healthcount.ToString();
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "flippills")
            {
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points + 5;
            Destroy(col.gameObject);
            flipon = true;
        }
        if (col.gameObject.name == "firepill")
        {
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points + 5;
            Destroy(col.gameObject);
            ball.GetComponent<MeshRenderer>().material = fireball;
            fireon = true;
        }
        if (col.gameObject.name == "slowpill")
        {
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points + 5;
            Destroy(col.gameObject);
            slowon = true;
            faston = false;
        }
        if (col.gameObject.name == "fastpill")
        {
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points + 5;
            Destroy(col.gameObject);
            faston = true;
            slowon = false;
        }
        if (col.gameObject.name == "pointsspills")
        {
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points + 30;
            Destroy(col.gameObject);
        }
    }
}
