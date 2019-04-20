using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill
{
    private string name;
    private int no;
    private int level;
    private int power;
    private bool[] scope = new bool[9];
    public skill(string name,int no,int level,int power,bool[] scope)
    {
        this.name = name;
        this.no = no;
        this.level = level;
        this.power = power;
        this.scope = scope;
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
    public int get_power()
    {
        return power;
    }
    public bool[] get_scope()
    {
        return scope;
    }
}
