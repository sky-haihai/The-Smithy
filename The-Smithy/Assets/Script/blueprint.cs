using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueprint
{
    private string name;
    private int no;
    private List<weapon> origin_weapon_list = new List<weapon>();
    public blueprint(string name, int no)
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
    public void set_list(List<weapon> weapons)
    {
        origin_weapon_list.AddRange(weapons);
    }
    public List<weapon> get_weapon_list()
    {
        return origin_weapon_list;
    }
}
