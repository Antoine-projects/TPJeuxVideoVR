using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneLevel3 : MonoBehaviour
{

    private LevelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager._Instance;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (!this.enabled) return;
        _levelManager.LoadAsychScene("NiveauLironShpak");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
