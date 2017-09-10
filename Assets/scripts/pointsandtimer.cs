using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pointsandtimer : MonoBehaviour
{
    public TextMesh pointtxt;
    public int points=0;
    public TextMesh timer;
    private float time;
    public int ftime;
    GameObject nlevel;
    void Start ()
    {
	

	}
  
    void Update()
    {
        pointtxt.text = points.ToString();
        nlevel = GameObject.Find("Base1");
        if (nlevel.GetComponent<nextlevel>().stop==false)
        {
            time += Time.deltaTime;
        }
        
        timer.text = time.ToString("F0");
        ftime = int.Parse(timer.text);
    }
}
