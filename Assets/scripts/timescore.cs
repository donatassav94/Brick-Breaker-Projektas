using UnityEngine;
using System.Collections;

public class timescore : MonoBehaviour
{
    private int points;
    private int time;
    public TextMesh pointstext;
    public TextMesh timetext;
    void Update ()
    {
        points = PlayerPrefs.GetInt("points");
        time = PlayerPrefs.GetInt("time");
        pointstext.text = points.ToString();
        timetext.text= time.ToString();
    }
}
