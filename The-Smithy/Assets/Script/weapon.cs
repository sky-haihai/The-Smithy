using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon
{
    private string name;
    public int no;
    private int level;
    private int stat_addition1;
    private int stat_addition2;
    private int stat_addition3;
    private int effect_addition1;
    private int effect_addition2;
    private skill skill;
    public weapon(string name, int no, int level, int stat_addition1, int stat_addition2
        , int stat_addition3, int effect_addition1, int effect_addition2,skill skill)
    {
        this.name = name;
        this.no = no;
        this.level = level;
        this.stat_addition1 = stat_addition1;
        this.stat_addition2 = stat_addition2;
        this.stat_addition3 = stat_addition3;
        this.effect_addition1 = effect_addition1;
        this.effect_addition2 = effect_addition2;
        this.skill = skill;
    }
    public string get_name()
    {
        return name;
    }
    public int get_level()
    {
        return level;
    }
    public int get_no()
    {
        return no;
    }
    public int get_stat_addition1()
    {
        return stat_addition1;
    }
    public int get_stat_addition2()
    {
        return stat_addition2;
    }
    public int get_stat_addition3()
    {
        return stat_addition3;
    }
    public int get_effect_addition1()
    {
        return effect_addition1;
    }
    public int get_effect_addition2()
    {
        return effect_addition2;
    }
    public skill get_skill()
    {
        return skill;
    }
}
