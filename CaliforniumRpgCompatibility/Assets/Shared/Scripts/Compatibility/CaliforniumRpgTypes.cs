using CommonCore.RpgGame.Rpg;
using PseudoExtensibleEnum;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonCore.RpgGame.Rpg
{
    //old RPG enum types

    [Obsolete]
    public enum WeaponSkillType
    {
        Unspecified, Melee, Archery, Guns
    }

    [Obsolete]
    public enum DamageType
    {
        Normal, Impact, Explosive, Energy, Poison, Thermal, Radiation
    }

    [Obsolete]
    public enum DamageEffector
    {
        Unspecified, Projectile, Explosion, Melee, Ambient, Internal //matches defaults for now
    }
}

namespace CommonCore.Compatibility
{
    [PseudoExtend(typeof(StatType))]
    public enum CaliforniumStatType
    {
        Resilience = 1,
        Dexterity = 2,
        Erudition = 3,
        Intuition = 4,
        Dialectic = 5,
        Subterfuge = 6,
        Serendipity = 7
    }

    [PseudoExtend(typeof(SkillType))]
    public enum CaliforniumSkillType
    {
        Melee = 1,
        MeleeAlacrity = 2,
        MeleePrecision = 3,
        MeleeBrawn = 4,
        Archery = 5,
        ArcheryDraw = 6,
        ArcherySteady = 7,
        Guns = 8,
        GunsAccuracy = 9,
        GunsRapidity = 10,
        Athletics = 11,
        AthleticsFurtive = 12,
        AthleticsFleet = 13,
        Magic = 14,
        MagicForce = 15,
        MagicElemental = 16,
        MagicDark = 17,
        Social = 18,
        SocialExchange = 19,
        SocialLeverage = 20,
        Security = 21,
        SecurityMechanisms = 22,
        SecurityComputers = 23
    }
}