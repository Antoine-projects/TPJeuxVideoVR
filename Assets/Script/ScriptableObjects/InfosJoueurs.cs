using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueurs : ScriptableObject
{
   public string nomJoueur;

   [Space(10)]
   [Header("Nombre de points")]
   public int nbPoints;

   [Space(10)]
   [Header("Nombre de de melons à trouver")]
   public int nbPointsMelon;


   void OnEnable(){
    nbPoints = 0;
    nbPointsMelon = 5;
   }
}
