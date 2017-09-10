using UnityEngine;
using System.Collections;

public class pausemenu : MonoBehaviour 
{
    public GameObject pause;
    public int Menu=0;
    private bool now=false;
    private int currentlevel;
	void Start () 
    {
        pause.SetActive(now);
	
	}
    void Update () 
    {
        if (Input.GetKeyDown("escape")&& now==false)
        {
            pause.SetActive(true);
            Time.timeScale = 0;
            now = true;
        }
        else if (Input.GetKeyDown("escape") && now == true)
        {
            pause.SetActive(false);
            Time.timeScale = 1;
            now = false;
        }
	}
    public void continueb()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void retry()
    {
        currentlevel = PlayerPrefs.GetInt("playerprefs");
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }
    public void escape()
    {
        Menu = 1;
        Application.LoadLevel(1);
        PlayerPrefs.SetInt("music ", 0);
        Time.timeScale = 1;
    }
    
}
