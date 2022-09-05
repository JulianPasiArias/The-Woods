
using UnityEngine;
using UnityEngine.UI;

public class DisplayHacha : MonoBehaviour
{
    public Hacha _axe;
    public Text textDescription, textoNombre;
    public Image imageAxe;

     
    void Start()
    {
        _axe.ShowData();
        textDescription.text = _axe.descripcionHacha;
        imageAxe.sprite = _axe.imagenHacha;
        textoNombre.text = _axe.nombreHacha;

    }

   
}
