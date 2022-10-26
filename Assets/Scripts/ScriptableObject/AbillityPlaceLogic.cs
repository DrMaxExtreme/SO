using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbillityPlaceLogic : ScriptableObject
{
    public abstract List<Unit> TryGetTarget(Vector2 screenPoint);
}
