using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Products/Product",fileName ="New Product")]
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite ItemIcon;
    public int ItemPrice;
}
