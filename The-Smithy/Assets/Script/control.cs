using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private mymaterial mymaterial;
    private List<mymaterial> material_list = new List<mymaterial>();
    private List<myweapon> weapon_list = new List<myweapon>();
    private void Awake()
    {
        //mymaterial = GetComponent<mymaterial>();
    }
    private void Start()
    {
        //以下为测试内容
        material_list.Add(new mymaterial("铁", 2, 1, 0, 0, 0, 0, 0));
        material_list.Add(new mymaterial("木枝", 7, 1, 2, 2, 0, 3, 6));
        material_list.Add(new mymaterial("木枝", 7, 1, 2, 2, 0, 3, 6));
        material_list.Add(new mymaterial("碎布", 8, 1, 0, 4, 2, 5, 6));
        material_list.Add(new mymaterial("碎布", 8, 1, 0, 4, 2, 5, 6));
        material_list.Add(new mymaterial("药草", 16, 2, 0, 6, 0, 15, 8));
        material_list.Add(new mymaterial("药草", 16, 2, 0, 6, 0, 15, 8));
        material_list.Add(new mymaterial("药草", 16, 2, 0, 6, 0, 15, 8));
        mix_material(material_list[0], material_list[5], material_list[7], material_list[3], material_list[6]);
        Debug.Log(material_list[3].get_name());
        Debug.Log(material_list[3].get_level());
        Debug.Log(material_list[3].get_stat_addition1());
        Debug.Log(material_list[3].get_effect_addition1());
        Debug.Log(material_list[3].get_effect_addition2());
        //
    }
    public void mix_material(mymaterial material1, mymaterial material2, mymaterial material3, mymaterial material4, mymaterial material5)
    {
        int mixlevel;
        float k=Random.Range(-0.5f,0.5f);
        Debug.Log((float)(material1.get_level() + material2.get_level() + material3.get_level() + material4.get_level() + material5.get_level())/5);
        Debug.Log("k:" + k);
        mixlevel = Mathf.RoundToInt((float)(material1.get_level()+ material2.get_level() + material3.get_level() + material4.get_level() + material5.get_level()) / 5 + k);
        if (mixlevel < 1)
            mixlevel = 1;
        if (mixlevel > 6)
            mixlevel = 6;
        int mix_stat_addition1, mix_stat_addition2, mix_stat_addition3;
        mix_stat_addition1 = material2.get_stat_addition1() + material3.get_stat_addition1() + material4.get_stat_addition1() + material5.get_stat_addition1();
        mix_stat_addition2 = material2.get_stat_addition2() + material3.get_stat_addition2() + material4.get_stat_addition2() + material5.get_stat_addition2();
        mix_stat_addition3 = material2.get_stat_addition3() + material3.get_stat_addition3() + material4.get_stat_addition3() + material5.get_stat_addition3();
        int[] effects = new int[8];
        int[] mix_effects = new int[2];
        for(int i=0;i<2;++i)
        {
            effects[i] = 0;
        }
        effects[0] = material2.get_effect_addition1();
        effects[1] = material2.get_effect_addition2();
        effects[2] = material3.get_effect_addition1();
        effects[3] = material3.get_effect_addition2();
        effects[4] = material4.get_effect_addition1();
        effects[5] = material4.get_effect_addition2();
        effects[6] = material5.get_effect_addition1();
        effects[7] = material5.get_effect_addition2();
        for(int i=0;i<8;++i)
        {
            int p = 0;
            if(effects[i]!=0)
            {
                for(int j=i+1;j<8;++j)
                {
                    if (effects[i] == effects[j])
                    {
                        ++p;
                        effects[j] = 0;
                    }
                }
                if(p>=2)
                {
                    if (mix_effects[0] == 0)
                        mix_effects[0] = effects[i];
                    else if(mix_effects[0]!=0)
                        mix_effects[1]=effects[i];
                }
            }
        }
        material_list.Add(new mymaterial("锻造原料", 0, mixlevel, mix_stat_addition1, mix_stat_addition2, mix_stat_addition3, mix_effects[0], mix_effects[1]));
        material_list.Remove(material1);
        material_list.Remove(material2);
        material_list.Remove(material3);
        material_list.Remove(material4);
        material_list.Remove(material5);
    }
    void make_weapon(mymaterial mymaterial,skill_book skill_Book,myblueprint blueprint)
    {

    }
}
