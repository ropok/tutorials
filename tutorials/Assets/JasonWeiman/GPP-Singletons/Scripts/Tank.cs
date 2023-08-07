using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public static List<Tank> AllEnabledTanks = new List<Tank>();

    private void OnEnable()
    {
        AllEnabledTanks.Add(this);
    }

    private void OnDisable()
    {
        AllEnabledTanks.Remove(this);
    }
}
