using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName ="Shop/Food", order = 51)]
public class Food : Goods
{
    [SerializeField] private float _calories;

    public override void ShowInfo() 
    {
        Debug.Log($"�������� - {Label} | �������� - {Description} | ������������ {_calories} | ���� - {Price} ");
    }
}
