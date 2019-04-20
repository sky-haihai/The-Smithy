using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myblueprint
{
    private string name;
    private int no;
    private List<myweapon> origin_weapon_list = new List<myweapon>();
    public myblueprint(string name, int no)
    {
        this.name = name;
        this.no = no;
    }
    public string get_name()
    {
        return name;
    }
    public int get_no()
    {
        return no;
    }
    public void set_list(List<myweapon> weapons)
    {
        origin_weapon_list.AddRange(weapons);
    }
    public List<myweapon> get_weapon_list()
    {
        return origin_weapon_list;
    }
}
