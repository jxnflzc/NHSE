﻿namespace NHSE.Core
{
    /// <summary>
    /// Door model for a house.
    /// </summary>
    public enum DoorKind : ushort
    {
        HouseDoorStandardAR = 0x00,
        HouseDoorStandardAS = 0x02,
        HouseDoorIronAS = 0x03,
        HouseDoorIronAR = 0x04,
        HouseDoorIronpartsAS = 0x05,
        HouseDoorIronpartsAR = 0x06,
        HouseTentPADoor = 0x07,
        HouseTentNADoor = 0x08,
        HouseDoorReliefAS = 0x09,
        HouseDoorReliefAR = 0x0A,
        HouseDoorJapaneseAS = 0x0E,
        HouseDoorJapaneseAR = 0x0F,
        HouseDoorWindowAS = 0x10,
        HouseDoorWindowAR = 0x11,
        HouseDoorIronGrillAS = 0x12,
        HouseDoorIronGrillAR = 0x13,
        HouseDoorChineseAS = 0x14,
        HouseDoorChineseAR = 0x15,
        HouseDoorSimpleAS = 0x16,
        HouseDoorSimpleAR = 0x17,
        _1 = 0x18,
        _2 = 0x19,
        HouseDoorCarvingAS = 0x1A,
        HouseDoorCarvingAR = 0x1B,
        HouseDoorCercleWindowAS = 0x1C,
        HouseDoorCercleWindowAR = 0x1D,
        HouseDoorVerticalWindowAS = 0x1E,
        HouseDoorVerticalWindowAR = 0x1F,
        HouseDoorLatticeAS = 0x20,
        HouseDoorLatticeAR = 0x21,
        HouseDoorSimplicityAS = 0x22,
        HouseDoorSimplicityAR = 0x23,
        _3 = 0x25,
        _4 = 0x26,
        HouseTentNBDoor = 0x27,
        HouseDoorIronGrillBS = 0x28,
        HouseDoorIronGrillCS = 0x29,
        HouseDoorIronGrillDS = 0x2A,
        HouseDoorIronGrillES = 0x2B,
        HouseDoorIronGrillFS = 0x2C,
        HouseDoorIronGrillBR = 0x2D,
        HouseDoorIronGrillCR = 0x2E,
        HouseDoorIronGrillDR = 0x2F,
        HouseDoorIronGrillER = 0x30,
        HouseDoorIronGrillFR = 0x31,
        HouseDoorCarvingBS = 0x32,
        HouseDoorCarvingCS = 0x33,
        HouseDoorCarvingDS = 0x34,
        HouseDoorCarvingES = 0x35,
        HouseDoorCarvingBR = 0x36,
        HouseDoorCarvingCR = 0x37,
        HouseDoorCarvingDR = 0x38,
        HouseDoorCarvingER = 0x39,
        HouseDoorIronGrillGS = 0x3A,
        HouseDoorIronGrillGR = 0x3B,
        HouseDoorIronGrillHS = 0x3C,
        HouseDoorIronGrillHR = 0x3D,
        HouseDoorVerticalWindowBS = 0x3E,
        HouseDoorVerticalWindowCS = 0x3F,
        HouseDoorVerticalWindowDS = 0x40,
        HouseDoorVerticalWindowES = 0x41,
        HouseDoorVerticalWindowFS = 0x42,
        HouseDoorVerticalWindowGS = 0x43,
        HouseDoorVerticalWindowHS = 0x44,
        HouseDoorVerticalWindowBR = 0x45,
        HouseDoorVerticalWindowCR = 0x46,
        HouseDoorVerticalWindowDR = 0x47,
        HouseDoorVerticalWindowER = 0x48,
        HouseDoorVerticalWindowFR = 0x49,
        HouseDoorVerticalWindowGR = 0x4A,
        HouseDoorVerticalWindowHR = 0x4B,
        HouseDoorReliefBS = 0x4C,
        HouseDoorReliefCS = 0x4D,
        HouseDoorReliefDS = 0x4E,
        HouseDoorReliefES = 0x4F,
        HouseDoorReliefFS = 0x50,
        HouseDoorReliefGS = 0x51,
        HouseDoorReliefHS = 0x52,
        HouseDoorReliefBR = 0x53,
        HouseDoorReliefCR = 0x54,
        HouseDoorReliefDR = 0x55,
        HouseDoorReliefER = 0x56,
        HouseDoorReliefFR = 0x57,
        HouseDoorReliefGR = 0x58,
        HouseDoorReliefHR = 0x59,
        HouseDoorIronpartsBS = 0x5A,
        HouseDoorIronpartsCS = 0x5B,
        HouseDoorIronpartsDS = 0x5C,
        HouseDoorIronpartsES = 0x5D,
        HouseDoorIronpartsFS = 0x5E,
        HouseDoorIronpartsGS = 0x5F,
        HouseDoorIronpartsHS = 0x60,
        HouseDoorIronpartsBR = 0x61,
        HouseDoorIronpartsCR = 0x62,
        HouseDoorIronpartsDR = 0x63,
        HouseDoorIronpartsER = 0x64,
        HouseDoorIronpartsFR = 0x65,
        HouseDoorIronpartsGR = 0x66,
        HouseDoorIronpartsHR = 0x67,
        HouseDoorSimpleBS = 0x84,
        HouseDoorSimpleCS = 0x85,
        HouseDoorSimpleDS = 0x86,
        HouseDoorSimpleES = 0x87,
        HouseDoorSimpleFS = 0x88,
        HouseDoorSimpleGS = 0x89,
        HouseDoorSimpleHS = 0x8A,
        HouseDoorSimpleBR = 0x8B,
        HouseDoorSimpleCR = 0x8C,
        HouseDoorSimpleDR = 0x8D,
        HouseDoorSimpleER = 0x8E,
        HouseDoorSimpleFR = 0x8F,
        HouseDoorSimpleGR = 0x90,
        HouseDoorSimpleHR = 0x91,
        HouseDoorJapaneseBS = 0x92,
        HouseDoorJapaneseCS = 0x93,
        HouseDoorJapaneseDS = 0x94,
        HouseDoorJapaneseES = 0x95,
        HouseDoorJapaneseFS = 0x96,
        HouseDoorJapaneseBR = 0x97,
        HouseDoorJapaneseCR = 0x98,
        HouseDoorJapaneseDR = 0x99,
        HouseDoorJapaneseER = 0x9A,
        HouseDoorJapaneseFR = 0x9B,
        HouseDoorLatticeBS = 0x9C,
        HouseDoorLatticeCS = 0x9D,
        HouseDoorLatticeDS = 0x9E,
        HouseDoorLatticeES = 0x9F,
        HouseDoorLatticeFS = 0xA0,
        HouseDoorLatticeGS = 0xA1,
        HouseDoorLatticeHS = 0xA2,
        HouseDoorLatticeBR = 0xA3,
        HouseDoorLatticeCR = 0xA4,
        HouseDoorLatticeDR = 0xA5,
        HouseDoorLatticeER = 0xA6,
        HouseDoorLatticeFR = 0xA7,
        HouseDoorLatticeGR = 0xA8,
        HouseDoorLatticeHR = 0xA9,
        HouseDoorCercleWindowBS = 0xAA,
        HouseDoorCercleWindowCS = 0xAB,
        HouseDoorCercleWindowDS = 0xAC,
        HouseDoorCercleWindowES = 0xAD,
        HouseDoorCercleWindowFS = 0xAE,
        HouseDoorCercleWindowGS = 0xAF,
        HouseDoorCercleWindowHS = 0xB0,
        HouseDoorCercleWindowBR = 0xB1,
        HouseDoorCercleWindowCR = 0xB2,
        HouseDoorCercleWindowDR = 0xB3,
        HouseDoorCercleWindowER = 0xB4,
        HouseDoorCercleWindowFR = 0xB5,
        HouseDoorCercleWindowGR = 0xB6,
        HouseDoorCercleWindowHR = 0xB7,
        HouseDoorJapaneseGS = 0xB8,
        HouseDoorJapaneseGR = 0xB9,
        HouseDoorSimplicityBS = 0xBA,
        HouseDoorSimplicityCS = 0xBB,
        HouseDoorSimplicityDS = 0xBC,
        HouseDoorSimplicityES = 0xBD,
        HouseDoorSimplicityFS = 0xBE,
        HouseDoorSimplicityGS = 0xBF,
        HouseDoorSimplicityHS = 0xC0,
        HouseDoorSimplicityBR = 0xC1,
        HouseDoorSimplicityCR = 0xC2,
        HouseDoorSimplicityDR = 0xC3,
        HouseDoorSimplicityER = 0xC4,
        HouseDoorSimplicityFR = 0xC5,
        HouseDoorSimplicityGR = 0xC6,
        HouseDoorSimplicityHR = 0xC7,
        HouseDoorChineseBS = 0xC8,
        HouseDoorChineseCS = 0xC9,
        HouseDoorChineseDS = 0xCA,
        HouseDoorChineseES = 0xCB,
        HouseDoorChineseFS = 0xCC,
        HouseDoorChineseGS = 0xCD,
        HouseDoorChineseHS = 0xCE,
        HouseDoorChineseBR = 0xCF,
        HouseDoorChineseCR = 0xD0,
        HouseDoorChineseDR = 0xD1,
        HouseDoorChineseER = 0xD2,
        HouseDoorChineseFR = 0xD3,
        HouseDoorChineseGR = 0xD4,
        HouseDoorChineseHR = 0xD5,
        HouseDoorWindowBS = 0xDD,
        HouseDoorWindowCS = 0xDE,
        HouseDoorWindowDS = 0xDF,
        HouseDoorWindowES = 0xE0,
        HouseDoorWindowFS = 0xE1,
        HouseDoorWindowGS = 0xE2,
        HouseDoorWindowHS = 0xE3,
        HouseDoorWindowBR = 0xE4,
        HouseDoorWindowCR = 0xE5,
        HouseDoorWindowDR = 0xE6,
        HouseDoorWindowER = 0xE7,
        HouseDoorWindowFR = 0xE8,
        HouseDoorWindowGR = 0xE9,
        HouseDoorWindowHR = 0xEA,
        HouseDoorIronBS = 0xEB,
        HouseDoorIronCS = 0xEC,
        HouseDoorIronDS = 0xED,
        HouseDoorIronES = 0xEE,
        HouseDoorIronFS = 0xEF,
        HouseDoorIronGS = 0xF0,
        HouseDoorIronHS = 0xF1,
        HouseDoorIronBR = 0xF2,
        HouseDoorIronCR = 0xF3,
        HouseDoorIronDR = 0xF4,
        HouseDoorIronER = 0xF5,
        HouseDoorIronFR = 0xF6,
        HouseDoorIronGR = 0xF7,
        HouseDoorIronHR = 0xF8,
        HouseDoorStandardBS = 0xF9,
        HouseDoorStandardCS = 0xFA,
        HouseDoorStandardDS = 0xFB,
        HouseDoorStandardES = 0xFC,
        HouseDoorStandardFS = 0xFD,
        HouseDoorStandardGS = 0xFE,
        HouseDoorStandardHS = 0xFF,
        HouseDoorStandardBR = 0x100,
        HouseDoorStandardCR = 0x101,
        HouseDoorStandardDR = 0x102,
        HouseDoorStandardER = 0x103,
        HouseDoorStandardFR = 0x104,
        HouseDoorStandardGR = 0x105,
        HouseDoorStandardHR = 0x106,
        HouseDoorReliefIS = 0x107,
        HouseDoorReliefIR = 0x108,
        HouseDoorReliefJS = 0x109,
        HouseDoorReliefJR = 0x10A,
        HouseDoorCarvingFS = 0x10B,
        HouseDoorCarvingFR = 0x10C,
        HouseDoorCercleWindowIS = 0x10D,
        HouseDoorCercleWindowIR = 0x10E,
        HouseDoorCercleWindowJS = 0x10F,
        HouseDoorCercleWindowJR = 0x110,
        HouseDoorVerticalWindowIS = 0x111,
        HouseDoorVerticalWindowIR = 0x112,
        HouseDoorVerticalWindowJS = 0x113,
        HouseDoorVerticalWindowJR = 0x114,
        HouseDoorWindowIS = 0x115,
        HouseDoorWindowIR = 0x116,
        HouseDoorWindowJS = 0x117,
        HouseDoorWindowJR = 0x118,
        HouseDoorStandardIS = 0x119,
        HouseDoorStandardIR = 0x11A,
        HouseDoorStandardJS = 0x11B,
        HouseDoorStandardJR = 0x11C,
        HouseDoorSimplicityIS = 0x11D,
        HouseDoorSimplicityIR = 0x11E,
        HouseDoorSimplicityJS = 0x11F,
        HouseDoorSimplicityJR = 0x120,
        HouseDoorIronGrillIS = 0x121,
        HouseDoorIronGrillIR = 0x122,
        HouseDoorIronGrillJS = 0x123,
        HouseDoorIronGrillJR = 0x124,
    }
}
