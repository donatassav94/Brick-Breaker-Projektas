using UnityEngine;
using System.Collections;

public class unlockLock : MonoBehaviour 
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("unlockLockOnlyonetime")==0)
        {
            PlayerPrefs.SetInt("unlockLock 1",1);
            for (int j = 2; j <= 20; j++)
            {
                PlayerPrefs.SetInt("unlockLock " + j, 0);
            }
            PlayerPrefs.SetInt("unlockLockOnlyonetime", 1);
        }
    }
}
