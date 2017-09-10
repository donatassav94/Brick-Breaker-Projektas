using UnityEngine;
using System.Collections;

public class buttonnext : MonoBehaviour
{
    private int currentlevel;
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
        currentlevel = PlayerPrefs.GetInt("playerprefs");
        PlayerPrefs.SetInt("unlockLock " + (currentlevel + 1), 1);
        Application.LoadLevel(currentlevel + 5);
        currentlevel++;
        PlayerPrefs.SetInt("playerprefs", currentlevel);
    }

}
