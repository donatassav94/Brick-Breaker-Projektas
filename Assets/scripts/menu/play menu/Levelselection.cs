using UnityEngine;
using System.Collections;

public class Levelselection : MonoBehaviour 
{
    public Sprite unlockedlevel;
    public TextMesh textm;
    string i;
    public void Start()
    {
        i = textm.text;
        if (PlayerPrefs.GetInt("unlockLock " + int.Parse(i)) == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = unlockedlevel;
            textm.color = Color.white;
        }
    }
    public void OnMouseEnter()
    {
        transform.localScale *= 0.9F;
    }
    public void OnMouseExit()
    {
        transform.localScale /= 0.9F;

    }
    void OnMouseUp()
    {
        if (PlayerPrefs.GetInt("unlockLock " + int.Parse(i)) == 1)
        {
            PlayerPrefs.SetInt("playerprefs", int.Parse(i));
            Application.LoadLevel(int.Parse(i) + 4);
        }
    }
}
