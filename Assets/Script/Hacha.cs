
using UnityEngine;

[CreateAssetMenu(fileName = "New Axe", menuName = "DefaultAxe")]
public class Hacha : ScriptableObject
{
    public string nombreHacha, descripcionHacha;
    public int damage;
    public Sprite imagenHacha;

    public void ShowData()
    {
        
    }
}
