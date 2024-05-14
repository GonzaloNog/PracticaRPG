using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //SINGLETON part1
    public Character character; //Variable del personaje 
    private int life;
    private string selectName;

    private void Awake()//SINGLETON part2
    {

        // SINGLETON
        if (!instance) // si instance no tiene informacion
        {
            instance = this; // instance se asigna a este objeto
            DontDestroyOnLoad(gameObject); // se indica que este obj no se destruya con la carga de escenas
        }
        else // si instance tiene info
        {
            Destroy(gameObject); // se destruye el gameObject, para que no haya dos o mas gms en el juego
        }
    }
    public void LoadScene(string sceneName)//Esta funcion carga un nivel por su nombre
    {
        SceneManager.LoadScene(sceneName);
    }
    public void SelectCharacter(int value) // para seleccionar el personaje
    {
       
        if (value == 0) // si es 0 se crea cowboy
        {
            character = new Cowboy(selectName);
        }
        else if (value == 1) // si es 1 el wizard
        {
            character = new Wizard(2f, selectName);
        }
        else if(value == 2) // si es 2 un arponero 
        {
            character = new Arponero(selectName);
        }
    }

    public string GetName() // para coger el nombre 
    {
        return selectName;
    }

    // setter
    public void SetName(string selectName) // para dar el nombre 
    {
        this.selectName = selectName;
    }
}
