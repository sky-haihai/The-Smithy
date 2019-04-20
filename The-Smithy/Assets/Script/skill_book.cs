using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_book
{
    private string name;
    private int no;
    private List<skill> origin_skill_list = new List<skill>();
    public skill_book(string name,int no)
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
    public void set_list(List<skill> skills)
    {
        origin_skill_list.AddRange(skills);
    }
    public List<skill> get_skill_list()
    {
        return origin_skill_list;
    }
}
