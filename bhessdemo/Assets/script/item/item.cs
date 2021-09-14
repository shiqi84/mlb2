
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "item")]
public class item : ScriptableObject
{
    new public string itemName = "ori";
    public Sprite icon = null;
    public bool isDefault = false;
public virtual void Use()
    {
      
    }

}
