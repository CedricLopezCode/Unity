using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{
    float unFloat = 2.5f;//  C# il faut le f
    
    // Types spécifique à Unity
    public Color uneCouleur;// = new Color(0.1F, 0.8F, 0.1F)
    public Material unMateriau; 
    
    
        
    void Start() // == Constructeur
    {
        print("Test start " + unFloat + " " + uneCouleur);
        Debug.Log("Nom objet = " + gameObject.name);
        print("Testr " + unFloat + " " + uneCouleur);
        int unInt = int.Parse(unFloat);
        /*gameObject.SetActive(false);
        Debug.Log("Objet Désactivé " + Time.time);
        gameObject.SetActive(true);
        Debug.Log("Objet réactivé "  + Time.time);*/
        //unMateriau.color = uneCouleur;

        NomFonctionEnCamelCase("sggsg", 56);
        print(NomFonctionEnCamelCase("fgjhgj", 98));
        print("OK");
        
    }
    
    void Update() // Update is called once per frame
    {
        
    }
    string NomFonctionEnCamelCase(string monString, int monInt){
        print(monString + monInt);
        return "le retour";
    }
}
