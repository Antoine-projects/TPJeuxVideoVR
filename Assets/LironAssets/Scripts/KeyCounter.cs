using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCounter : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake(){
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();

    void OnEnable() => Key.OnCollected += OnKeyCollected;
    void OnDisable() => Key.OnCollected -= OnKeyCollected;


    void OnKeyCollected(){
        count++;
        UpdateCount();
    }

    void UpdateCount(){
        text.text = $"{count} / {Key.total}";
    }
}
