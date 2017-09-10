using UnityEngine;

using System.Collections;

public class brick1 : MonoBehaviour 
{
    public GameObject bricks;
    public static int childs;
    public GameObject health;
    public GameObject flippills;
    public GameObject firepill;
    public GameObject slowpill;
    public GameObject fastpill;
    public GameObject pointsspills;
    GameObject ptext;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "ball")
        {

            float rand = Random.Range(0, 100);
            if (rand > 0 && rand < 10)
            {
                GameObject newhpa = (Instantiate(health, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject);
                newhpa.name = "health";
                newhpa.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.01f));
            }
            if (rand > 20 && rand < 30)
            {
                GameObject newnextlevel = (Instantiate(flippills, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject);
                newnextlevel.name = "flippills";
                newnextlevel.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.01f));
            }
            if (rand > 40 && rand < 50)
            {
                GameObject newfirepill = (Instantiate(firepill, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject);
                newfirepill.name = "firepill";
                newfirepill.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.01f));
            }
            if (rand > 60 && rand < 70)
            {
                GameObject newslowpill = (Instantiate(slowpill, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject);
                newslowpill.name = "slowpill";
                newslowpill.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.01f));
            }
            if (rand > 80 && rand < 90)
            {
                GameObject newfastpill = (Instantiate(fastpill, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject);
                newfastpill.name = "fastpill";
                newfastpill.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.01f));
            }
            if (rand > 90 && rand < 100)
            {
                GameObject newpointsspills = (Instantiate(pointsspills, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject);
                newpointsspills.name = "pointsspills";
                newpointsspills.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.01f));
            }
            Destroy(gameObject);
            ptext = GameObject.Find("Points2");
            ptext.GetComponent<pointsandtimer>().points= ptext.GetComponent<pointsandtimer>().points+10;
            nextlevel.childs--;
            
        }

    }
}
