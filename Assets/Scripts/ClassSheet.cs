using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSheet : ScriptableObject
{
    public string className;

    [Range(1, 10)]
    public int attkPerLvl;
    [Range(1, 10)]
    public int defPerLvl;
    [Range(1, 10)]
    public int hpPerLvl;
    [Range(1, 10)]
    public int spPerLvl;

    [Range(0, 2)]
    public int attkRangePerLvl;
}
