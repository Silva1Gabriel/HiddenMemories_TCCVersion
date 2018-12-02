using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    public GameObject Dont;
    private void Awake()
    {
        DontDestroyOnLoad(Dont);
    }
}
