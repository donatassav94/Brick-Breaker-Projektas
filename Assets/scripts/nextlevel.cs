using UnityEngine;
using System.Collections;

public class nextlevel : MonoBehaviour 
{
    public GameObject bricks;
    public static int childs;
    public bool stop = false;
    GameObject points;
    GameObject time;

    void Awake ()
    {
        childs = bricks.transform.childCount;
	}
	
	void Update () 
    {
        stop = false;
        if ( childs == 0)
        {
            stop = true;
            points = GameObject.Find("Points2");
            time = GameObject.Find("timer");
            PlayerPrefs.SetInt("points", points.GetComponent<pointsandtimer>().points);
            PlayerPrefs.SetInt("time", time.GetComponent<pointsandtimer>().ftime);
            Application.LoadLevel(20);
            
        }
	}
}
