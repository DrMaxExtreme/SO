using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Abillites/New Abillity")]
public class Abillity : ScriptableObject
{
    [SerializeField] private AbillityPlaceLogic _placeLogic;
    [SerializeField] private List<AbillityAction> abillityActions;

    public void ApplyAction(List<Unit> targets)
    {
        foreach (var action in abillityActions)
        {
            foreach (var target in targets)
            {
                action.Action(target);
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoint)
    {
        return _placeLogic.TryGetTarget(screenPoint);
    }
}
