using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Shop/Sword", order = 51)]
public class Sword : Goods
{
    [SerializeField] private float _damage;

    public override void ShowInfo()
    {
        Debug.Log($"�������� - {Label} | �������� - {Description} | ���� {_damage} | ���� - {Price} ");
    }
}
