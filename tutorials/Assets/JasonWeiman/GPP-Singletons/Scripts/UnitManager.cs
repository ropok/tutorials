using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class UnitManager
{
    private static List<GameObject> _units = new List<GameObject>();

    public static void AddUnit(GameObject unit)
    {
        _units.Add(unit);
    }

    public static IEnumerable<GameObject> GetUnitsAtPoint(Vector3 point, float maxDistance)
    {
        return _units.Where(t => Vector3.Distance(t.transform.position, point) <= maxDistance);
    }
}
