using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HeroSheet : ScriptableObject
{
    public string heroName;
    public GameManager.element heroElement;
    public ClassSheet heroClass;

    [Range(1,10)]
    public int startAttk;
    [Range(1, 10)]
    public int startDef;
    [Range(1, 10)]
    public int startHP;
    [Range(1, 10)]
    public int startSP;



}
