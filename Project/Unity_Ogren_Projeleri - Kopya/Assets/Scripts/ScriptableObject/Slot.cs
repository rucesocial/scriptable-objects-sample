using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item Item;
    public Text ItemNameText,ItemPrice;
    public Image ItemIcon;
    public GameObject market;
    private void Start()
    {
        ItemNameText.text = Item.ItemName;
        ItemIcon.sprite = Item.ItemIcon;
        ItemPrice.text = Item.ItemPrice+" $ ";
    }
    public  void Market()
    {
        this.gameObject.SetActive(false);
        market.SetActive(true);
    }
}
