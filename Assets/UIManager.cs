using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //Libreria TMPRo

public class UIManager : MonoBehaviour
{
    public TMPro.TMP_Dropdown Class;//Variable que referencia al dropdown
    public TMP_InputField namePlayer;
    public void setClassPlayer()
    {
        GameManager.instance.SelectCharacter(Class.value);//Elegimos el caracter segun el valor del Dropdown
        GameManager.instance.SetName(namePlayer.text);//Elegimos el nombre del player
    }
    public void LoadScene(string sceneName)
    {
        GameManager.instance.LoadScene(sceneName); // para cambiar la escena 
    }
}
