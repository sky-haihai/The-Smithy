using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheSmithy.Data {

    public enum Effects {
        FireProof,
        Combustible,

        Gorgeous,
        Ugly,

        LightningProof,
        LightningWeak,

        DustProof,

        FreezeProof,
        FreezeWeak,

        PoisonProof,

        //buff
        /// <summary>
        /// 闪光，速度2倍
        /// </summary>
        Inlighten,
        /// <summary>
        /// 勇敢，攻击1.5倍
        /// </summary>
        Brave,
        /// <summary>
        /// 爱心，生命1.5倍
        /// </summary>
        Lovely,
        /// <summary>
        /// 坚强，防御1.5倍
        /// </summary>
        Strong,
        ///加入没有效果
        None,
    }

    public enum Skills {
        HorizontalCut1,
        HorizontalCut2,
        HorizontalCut3,

        CrossCut1,
        CrossCut2,
        CrossCut3,

        Heal1,
        Heal2,
        Heal3,

        FireBall1,
        FireBall2,
        FireBall3,

        CodeV1,
        CodeV2,
        CodeV3,

        CodeX1,
        CodeX2,
        CodeX3,

        DevilEye1,
        DevilEye2,
        DevilEye3,

        HeroNeverDie1,
        HeroNeverDie2,
        HeroNeverDie3,

        Fencing1,
        Fencing2,
        Fencing3,

        HeavyCut1,
        HeavyCut2,
        HeavyCut3,

        LightArrow1,
        LightArrow2,
        LightArrow3,

        ShieldAttack1,
        ShieldAttack2,
        ShieldAttack3,

        Laido1,
        Laido2,
        Laido3,

        DualBlade1,
        DualBlade2,
        DualBlade3,

        SwallowBack1,
        SwallowBack2,

        HolyBreath1,
        HolyBreath2,
        HolyBreath3,

        HolyWall1,
        HolyWall2,
        HolyWall3,

        KingsOrder1,
        KingsOrder2,

        HolyClaw1,
        HolyClaw2,
        HolyClaw3,

        ShadowTeeth1,
        ShadowTeeth2,
        ShadowTeeth3,

        AbsoluteShadow1,
        AbsoluteShadow2,

        PowerCharge1,
        PowerCharge2,

        VacuumZone1,
        VacuumZone2,
        VacuumZone3,

        Nuke1,
        Nuke2,
    }

    public enum WeaponTypes {
        Sword,
        Spear,
        Knife,
        Wand,
    }

    public enum BluePrints {
        Standard,
        Fashion,
        Royal,
        Worriar,
        Jade,
        KuroNeko,
    }

    public enum SkillBooks {

        Standard,
        Fashion,
        Royal,
        Worriar,
        Jade,
        KuroNeko,
    }

    public enum SetBonusTypes {
        AttackPlus,
        AttackMultiply,
        DefensePlus,
        DefenseMultiply,
        SpeedPlus,
        SpeedMultiply,
        AllPlus,
        AllMultiply,
    }

    public class MyTypes { }
}
