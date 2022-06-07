using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defence
{
    public int Aid;
    public int Did;
    public int CardNo;
    public string description;
    public bool stage1;
    public bool stage2;
    public bool stage3;
    public bool stage4;
    public bool stage5;
    public bool stage6;

    public Defence(int Aid, int Did, int CardNo, string description, bool stage1, bool stage2, bool stage3, bool stage4, bool stage5, bool stage6)
    {
        this.Aid = Aid;
        this.Did = Did;
        this.CardNo = CardNo;
        this.description = description;
        this.stage1 = stage1;
        this.stage2 = stage2;
        this.stage3 = stage3;
        this.stage4 = stage4;
        this.stage5 = stage5;
        this.stage6 = stage6;
    }
    public Defence(Defence defence)
    {
        this.Aid = defence.Aid;
        this.Did = defence.Did;
        this.CardNo = defence.CardNo;
        this.description = defence.description;
        this.stage1 = defence.stage1;
        this.stage2 = defence.stage2;
        this.stage3 = defence.stage3;
        this.stage4 = defence.stage4;
        this.stage5 = defence.stage5;
        this.stage6 = defence.stage6;
    }
}
