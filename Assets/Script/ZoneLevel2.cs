using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneLevel2 : MonoBehaviour
{

    private LevelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager._Instance;
    }


    private void OnTriggerEnter(Collider other)
    {
        _levelManager.LoadAsychScene("NiveauAntoineDaoust 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
