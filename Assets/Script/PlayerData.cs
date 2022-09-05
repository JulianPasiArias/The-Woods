
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "PlayerData")]

public class PlayerData : ScriptableObject
{
    public string nombrePlayer, descripcionPlayer, vida, velocidad;
    public int damage;
    public Sprite imagenPlayer;

    public void ShowData()
    {
        

    }
}
