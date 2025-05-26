using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_Text nombreTexto;

    void Awake()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        WebGLInput.captureAllKeyboardInput = false;
#endif
    }
    public void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void RecibirNombre(string nombre)
    {
        Debug.Log("Nombre recibido desde React: " + nombre);
        nombreTexto.text = nombre;
    }
}
