
using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour
{
    public PlayerData _player;
    public Text textDescription, textoNombre, textoSpeed, textoVida;
    public Image imagePlayer;


    void Start()
    {
        _player.ShowData();
        textDescription.text = _player.descripcionPlayer;
        imagePlayer.sprite = _player.imagenPlayer;
        textoNombre.text = _player.nombrePlayer;
        textoSpeed.text = _player.velocidad;
        textoVida.text = _player.vida;
      
    }
}
