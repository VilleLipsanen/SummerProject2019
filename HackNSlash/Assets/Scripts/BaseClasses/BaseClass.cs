using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{

    int HP;
    int curHP;

    int Stamina;
    int curStamina;

    int Speed;
    int curSpeed;

    int Mana;
    int curMana;

    int Atk;
    int curAtk;

    int Def;
    int curDef;

    int Crit;
    int curCrit;

    int Level;
    int Exp;

    List<BaseAttack> attacks;
    List<BaseMagic> magics;

}
