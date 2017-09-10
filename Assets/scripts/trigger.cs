using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class trigger : MonoBehaviour {

    public GameObject ballPref;
    public GameObject pillsballPref;
    public Transform paddleObj;
    GameObject ball;
    GameObject pillsball;
    int score;
    public int healthcount;
    public Text t;
    public int level;
    GameObject paddle;
    GameObject ptext;
    void Start() {
        healthcount = 2;
        t.text = healthcount.ToString();
    }
    void Update()
    {
        paddle = GameObject.Find("paddle");
        ball = GameObject.FindGameObjectWithTag("ball");
        if (healthcount < 0)
        {
            Application.LoadLevel(level);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball")
        {
            ptext = GameObject.Find("Points2");
            ptext.GetComponent<pointsandtimer>().points = ptext.GetComponent<pointsandtimer>().points -10;
            Destroy(ball);
            healthcount--;
            if (healthcount > -1)
            {
                t.text = healthcount.ToString();
            }
            (Instantiate(ballPref, new Vector2(paddleObj.transform.position.x, paddleObj.transform.position.y + 0.28F), Quaternion.identity) as GameObject).transform.parent = paddleObj;
            paddle.GetComponent<moving>().fireon = false;
            paddle.GetComponent<moving>().flipon = false;
            paddle.GetComponent<moving>().slowon = false;
            paddle.GetComponent<moving>().faston = false;
        }
    }
}
