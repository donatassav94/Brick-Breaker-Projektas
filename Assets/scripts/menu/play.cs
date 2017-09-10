using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

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
        Application.LoadLevel(1);
    }
	
}
