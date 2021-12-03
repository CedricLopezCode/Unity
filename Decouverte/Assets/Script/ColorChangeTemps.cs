using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeTemps : MonoBehaviour
{
    // Variables
    //public Material materielFdeT;
    void Start() //Constructeur
    {
        print("Création matériau");
        InvokeRepeating("ChangeCouleurToutes3sec", 3.0f, 3.0f);
    } //fin Constructeur

    void ChangeCouleurToutes3sec(){
        
        //Génération variables //%255 +64 +128 +192
        //R
        float rouge = Random.Range(0.0f, 1.0f);
        //G
        float vert = Random.Range(0.0f, 1.0f);
        //B
        float bleu = Random.Range(0.0f, 1.0f);
        //A
        float trans = Random.Range(0.0f, 1.0f);

        print("Rouge : " + rouge + " Vert  : " + vert + " Bleu  : " + bleu + " Trans  : " + trans);
  
        //Génération Couleur
        Color nvCol = new Color(rouge, vert, bleu, trans);
        print("Couleur : " + nvCol);

        //Génération matériau
        GetComponent<Renderer>().material.color = nvCol;
        //materielFdeT.SetFloat(rouge,vert,bleu,trans); 

    }

    // Update is called once per frame
    void Update()//fin Update
    {

    }//fin Update
}
