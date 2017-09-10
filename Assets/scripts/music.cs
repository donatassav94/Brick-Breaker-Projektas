using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

    public AudioSource source;
    public AudioClip musics1;
    public AudioClip musics2;
    public AudioClip musics3;
    private int play;
    private int currentlevel;
    
	void Start ()
    {
        play = PlayerPrefs.GetInt("music "); ;
        currentlevel = PlayerPrefs.GetInt("playerprefs");
        if (0<currentlevel && currentlevel<6)
        {
            if (play == 0)
            {
                source.PlayOneShot(musics1);
                PlayerPrefs.SetInt("music ", 1);
            }
        }
        if (5 < currentlevel && currentlevel < 11)
        {
            if (play == 0)
            {
            source.PlayOneShot(musics2);
            PlayerPrefs.SetInt("music ", 1);
            }
        }
        if (10 < currentlevel && currentlevel < 16)
        {
            if (play == 0)
            {
            source.PlayOneShot(musics3);
            PlayerPrefs.SetInt("music ", 1);
            }
        }
	}
	
	void Update () 
    {
        pausemenu Pausemenu=gameObject.GetComponent<pausemenu>();
        currentlevel = PlayerPrefs.GetInt("playerprefs");
        if (currentlevel != 5 || currentlevel != 10 || currentlevel != 15||Pausemenu.Menu!=1)
        {
            DontDestroyOnLoad(this);
        }
        else 
        {
            PlayerPrefs.SetInt("music ", 0);
        }
	}
}
