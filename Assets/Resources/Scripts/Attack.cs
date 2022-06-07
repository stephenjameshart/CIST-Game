using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack
{
    public int attackid;
    public int sequenceid;
    public string description;
    public int attackdifficulty;
    public bool counterfeiting;
    public bool informationleakage;
    public bool sabotage;
    public bool tampering;
    public bool stage1;
    public bool stage2;
    public bool stage3;
    public bool stage4;
    public bool stage5;
    public bool stage6;
    public string informationAttack;

    public Attack(int attackid, int sequenceid, string description, int attackdifficulty, bool counterfeiting, bool informationleakage, bool sabotage, bool tampering, bool stage1, bool stage2, bool stage3, bool stage4, bool stage5, bool stage6, string informationAttack)
    {
        this.attackid = attackid;
        this.sequenceid = sequenceid;
        this.description = description;
        this.attackdifficulty = attackdifficulty;
        this.counterfeiting = counterfeiting;
        this.informationleakage = informationleakage;
        this.sabotage = sabotage;
        this.tampering = tampering;
        this.stage1 = stage1;
        this.stage2 = stage2;
        this.stage3 = stage3;
        this.stage4 = stage4;
        this.stage5 = stage5;
        this.stage6 = stage6;
        this.informationAttack = informationAttack;
    }
public Attack(Attack attack)
    {
        this.attackid = attack.attackid;
        this.sequenceid = attack.sequenceid;
        this.description = attack.description;
        this.attackdifficulty = attack.attackdifficulty;
        this.counterfeiting = attack.counterfeiting;
        this.informationleakage = attack.informationleakage;
        this.sabotage = attack.sabotage;
        this.tampering = attack.tampering;
        this.stage1 = attack.stage1;
        this.stage2 = attack.stage2;
        this.stage3 = attack.stage3;
        this.stage4 = attack.stage4;
        this.stage5 = attack.stage5;
        this.stage6 = attack.stage6;
        this.informationAttack = attack.informationAttack;
    }
}
