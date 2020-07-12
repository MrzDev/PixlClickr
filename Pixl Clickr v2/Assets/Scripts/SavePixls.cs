using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;
using System.Numerics;

public class SavePixls : MonoBehaviour {
    public static ObscuredBool WelcomerOnceOpened = false;
    public static ObscuredInt ChangelogOnceOpened;
    public static ObscuredDouble PixlCount;
    public static ObscuredDouble StatisticPixlCount;
    public static ObscuredDouble StatisticGems;
    public static ObscuredDouble StatisticsUpgrades;
    public static ObscuredDouble StatisticsClicks;
    public static ObscuredDouble Gems = 0;
    public ObscuredDouble InternalPixl;
    public static ObscuredDouble GTapPrice = 50;
    public static ObscuredDouble GTapLvl = 0;
    public static ObscuredDouble PixlsAdded = 1;
    public static ObscuredBool Cheater = false;
    public static ObscuredDouble PeachS = 0;    
    public static ObscuredDouble PixlMakerPrice = 150;
    public static ObscuredDouble CheatCount = 0;
    public static ObscuredDouble PixlFactoryPrice = 300;
    public static ObscuredDouble BoughtHell1 = 0;
    public static ObscuredDouble BoughtHazard1 = 0;
    public static ObscuredDouble BoughtSilver1 = 0;
    public static ObscuredDouble BoughtGold1 = 0;
    public static ObscuredDouble BoughtRainbow1 = 0;
    public static ObscuredDouble BoughtBlurred1 = 0;
    public static ObscuredDouble BoughtBlue1 = 0;
    public static ObscuredDouble BoughtGreen1 = 0;
    public static ObscuredDouble BoughtOcean1 = 0;
    public static ObscuredDouble Rank = 0;
    public static ObscuredDouble RankCost = 0;
    public static ObscuredDouble PeachSMulti = 1;
    public static ObscuredDouble PixlIndustryPrice = 1000;
    public static ObscuredDouble PixlCompanyPrice = 10000;
    public static ObscuredDouble AtomicPixlPrice = 500000000;
    public static ObscuredDouble AtomicPixlv2Price = 2000000000;
    public static ObscuredDouble QuantumPixlPrice = 5E10;
    public static ObscuredDouble QuantumPixlv2Price = 15E10;
    public static ObscuredDouble GalaxyPixlPrice = 5E12;
    public static ObscuredDouble AlienPixlPrice = 20E12;
    public static ObscuredDouble NanoPixlPrice = 100E12;
    public static ObscuredDouble VirusPixlPrice = 10E15;
    public static ObscuredDouble KrytoPixlPrice = 50E15;
    public static ObscuredDouble KrytoPixlv2Price = 200E15;
    public static ObscuredDouble UranPixlPrice = 10E18;
    public static ObscuredDouble PlutoniumPixlPrice = 100E18;
    public static ObscuredFloat Time = 300;
    public static ObscuredFloat MaxTimeFix = 0;
    public static ObscuredFloat TimeBought = 0;
    public static ObscuredDouble Statistic_Achievements;
    public static ObscuredInt UsedSkin;
    public static ObscuredDouble OfflineMulti = 0.1;


    // Use this for initialization
    /*
    void Start () {
        // PlayerPref wird ausgelesen
        InternalPixl = PixlCount;      
        PixlCount = ObscuredPrefs.GetDouble("Pixl_Count");
        GTapPrice = ObscuredPrefs.GetDouble("GTapPrice");
        PixlsAdded = ObscuredPrefs.GetDouble("PixlsAdded");
        PeachS = ObscuredPrefs.GetDouble("PeachS");
        Cheater = ObscuredPrefs.GetBool("Cheater");
        CheatCount = ObscuredPrefs.GetDouble("CheatCount");
        PixlMakerPrice = ObscuredPrefs.GetDouble("PixlMakerPrice");
        PixlFactoryPrice = ObscuredPrefs.GetDouble("PixlFactoryPrice");
        Gems = ObscuredPrefs.GetDouble("Gems");
        BoughtSilver1 = ObscuredPrefs.GetDouble("BoughtSilver1");
        BoughtGold1 = ObscuredPrefs.GetDouble("BoughtGold1");
        BoughtRainbow1 = ObscuredPrefs.GetDouble("BoughtRainbow1");
        BoughtBlurred1 = ObscuredPrefs.GetDouble("BoughtBlurred1");
        BoughtBlue1 = ObscuredPrefs.GetDouble("BoughtBlue1");
        BoughtGreen1 = ObscuredPrefs.GetDouble("BoughtGreen1");
        BoughtOcean1 = ObscuredPrefs.GetDouble("BoughtOcean1");
        Rank = ObscuredPrefs.GetDouble("Rank");
        RankCost = ObscuredPrefs.GetDouble("RankCost");
        GTapLvl = ObscuredPrefs.GetDouble("GTapLvl");
        PeachSMulti = ObscuredPrefs.GetDouble("PeachSMulti");       
        StatisticPixlCount = ObscuredPrefs.GetDouble("StatisticPixlCount");
        StatisticGems = ObscuredPrefs.GetDouble("StatisticGems");
        StatisticsUpgrades = ObscuredPrefs.GetDouble("StatisticsUpgrades");
        StatisticsClicks = ObscuredPrefs.GetDouble("StatisticsClicks");
        PixlIndustryPrice = ObscuredPrefs.GetDouble("PixlIndustryPrice");
        PixlCompanyPrice = ObscuredPrefs.GetDouble("PixlCompanyPrice");
        AtomicPixlPrice = ObscuredPrefs.GetDouble("AtomicPixlPrice");
        AtomicPixlv2Price = ObscuredPrefs.GetDouble("AtomicPixlv2Price");
        QuantumPixlPrice = ObscuredPrefs.GetDouble("QuantumPixlPrice");
        QuantumPixlv2Price = ObscuredPrefs.GetDouble("QuantumPixlv2Price");
        GalaxyPixlPrice = ObscuredPrefs.GetDouble("GalaxyPixlPrice");
        AlienPixlPrice = ObscuredPrefs.GetDouble("AlienPixlPrice");
        NanoPixlPrice = ObscuredPrefs.GetDouble("NanoPixlPrice");
        VirusPixlPrice = ObscuredPrefs.GetDouble("VirusPixlPrice");
        KrytoPixlPrice = ObscuredPrefs.GetDouble("KrytoPixlPrice");
        KrytoPixlv2Price = ObscuredPrefs.GetDouble("KrytoPixlv2Price");
        UranPixlPrice = ObscuredPrefs.GetDouble("UranPixlPrice");
        PlutoniumPixlPrice = ObscuredPrefs.GetDouble("PlutoniumPixlPrice");
        Time = ObscuredPrefs.GetFloat("Time");
        MaxTimeFix = ObscuredPrefs.GetFloat("MaxTimeFix");
        TimeBought = ObscuredPrefs.GetFloat("TimeBought");
        Promos.Code1 = ObscuredPrefs.GetInt("Code1");
        Promos.Code2 = ObscuredPrefs.GetInt("Code2");
        Promos.Code3 = ObscuredPrefs.GetInt("Code3");
        Promos.Code4 = ObscuredPrefs.GetInt("Code4");
        Promos.Code5 = ObscuredPrefs.GetInt("Code5");
        Promos.Code6 = ObscuredPrefs.GetInt("Code6");
        Promos.Code7 = ObscuredPrefs.GetInt("Code7");
        Promos.Code8 = ObscuredPrefs.GetInt("Code8");
        Promos.Code9 = ObscuredPrefs.GetInt("Code9");
        Promos.Code10 = ObscuredPrefs.GetInt("Code10");
        Promos.Code11 = ObscuredPrefs.GetInt("Code11");
        Promos.Code12 = ObscuredPrefs.GetInt("Code12");
        Promos.Code13 = ObscuredPrefs.GetInt("Code13");
        Promos.Code14 = ObscuredPrefs.GetInt("Code14");
        Promos.Code15 = ObscuredPrefs.GetInt("Code15");
        Promos.Code16 = ObscuredPrefs.GetInt("Code16");
        Promos.Code17 = ObscuredPrefs.GetInt("Code17");
        Promos.Code18 = ObscuredPrefs.GetInt("Code18");
        WelcomerOnceOpened = ObscuredPrefs.GetBool("WelcomerOnceOpened");
        ChangelogOnceOpened = ObscuredPrefs.GetInt("ChangelogOnceOpened");
        PlayTimeRewards.PlayedTime = ObscuredPrefs.GetInt("PlayedTime");
        PlayTimeRewards.RewardTime = ObscuredPrefs.GetInt("RewardTime");
        PowerUps.PowerUpPixls = ObscuredPrefs.GetDouble("PowerUpPixls");
        PowerUps.Timer1 = ObscuredPrefs.GetInt("Timer1");
        PowerUps.Timer1On = ObscuredPrefs.GetBool("Timer1On");
        Achievements.PixlsReward = ObscuredPrefs.GetDouble("PixlsReward");
        Achievements.PSReward = ObscuredPrefs.GetDouble("PSReward");
        Achievements.RankReward = ObscuredPrefs.GetDouble("RankReward");
        Statistic_Achievements = ObscuredPrefs.GetDouble("Statistic_Achievements");
        BoughtHazard1 = ObscuredPrefs.GetDouble("BoughtHazard1");
        BoughtHell1 = ObscuredPrefs.GetDouble("BoughtHell1");
        UsedSkin = ObscuredPrefs.GetInt("UsedSkin");
        OfflineMulti = ObscuredPrefs.GetDouble("OfflineMulti");
        ObscuredCheatingDetector.StartDetection(OnCheaterDetected);
        ObscuredPrefs.onAlterationDetected = OnCheaterDetected;

    }

    public void OnCheaterDetected()
    {
        Cheater = true;
    }

    // Update is called once per frame
    void Update () {
        //wird reigeschrieben
        if (PixlsAdded == 0)
        {
            PixlsAdded = 1;
            GTapPrice = 50;
            PixlMakerPrice = 150;
            PixlFactoryPrice = 300;
            PixlIndustryPrice = 1000;
            PixlCompanyPrice = 10000;
        }
        if (PixlIndustryPrice == 0) PixlIndustryPrice = 1000;
        if (PixlCompanyPrice == 0) PixlCompanyPrice = 10000;
        if (AtomicPixlPrice == 0) AtomicPixlPrice = 500000000;
        if (AtomicPixlv2Price == 0) AtomicPixlv2Price = 2000000000;
        if (QuantumPixlPrice == 0) QuantumPixlPrice = 5E10;
        if (QuantumPixlv2Price == 0) QuantumPixlv2Price = 15E10;
        if (GalaxyPixlPrice == 0) GalaxyPixlPrice = 5E12;
        if (AlienPixlPrice == 0) AlienPixlPrice = 20E12;
        if (NanoPixlPrice == 0) NanoPixlPrice = 100E12;
        if (VirusPixlPrice == 0) VirusPixlPrice = 10E15;
        if (KrytoPixlPrice == 0) KrytoPixlPrice = 50E15;
        if (KrytoPixlv2Price == 0) KrytoPixlv2Price = 200E15;
        if (UranPixlPrice == 0) UranPixlPrice = 10E18;
        if (PlutoniumPixlPrice == 0) PlutoniumPixlPrice = 100E18;
        if (OfflineMulti == 0) OfflineMulti = 0.1;
        if (PeachSMulti == 0)
        {
            PeachSMulti = 1;
        }
        if (Cheater == true)
        {
            CheatCount++;

            if (CheatCount >= 5)
            {
                ObscuredPrefs.DeleteAll();           
            }
            Cheater = false;
        }

        InternalPixl = PixlCount;
        ObscuredPrefs.SetDouble("Pixl_Count", PixlCount);
        ObscuredPrefs.SetDouble("GTapPrice", GTapPrice);
        ObscuredPrefs.SetDouble("PixlsAdded", PixlsAdded);
        ObscuredPrefs.SetDouble("PeachS", PeachS);
        ObscuredPrefs.SetBool("Cheater", Cheater);
        ObscuredPrefs.SetDouble("CheatCount", CheatCount);
        ObscuredPrefs.SetDouble("PixlMakerPrice", PixlMakerPrice);
        ObscuredPrefs.SetDouble("PixlFactoryPrice", PixlFactoryPrice);
        ObscuredPrefs.SetDouble("Gems", Gems);
        ObscuredPrefs.SetDouble("BoughtSilver1", BoughtSilver1);
        ObscuredPrefs.SetDouble("BoughtGold1", BoughtGold1);
        ObscuredPrefs.SetDouble("BoughtRainbow1", BoughtRainbow1);
        ObscuredPrefs.SetDouble("BoughtBlurred1", BoughtBlurred1);
        ObscuredPrefs.SetDouble("BoughtBlue1", BoughtBlue1);
        ObscuredPrefs.SetDouble("BoughtGreen1", BoughtGreen1);
        ObscuredPrefs.SetDouble("BoughtOcean1", BoughtOcean1);
        ObscuredPrefs.SetDouble("Rank", Rank);
        ObscuredPrefs.SetDouble("RankCost", RankCost);
        ObscuredPrefs.SetDouble("GTapLvl", GTapLvl);
        ObscuredPrefs.SetDouble("PeachSMulti", PeachSMulti);        
        ObscuredPrefs.SetDouble("StatisticPixlCount", StatisticPixlCount);
        ObscuredPrefs.SetDouble("StatisticGems", StatisticGems);
        ObscuredPrefs.SetDouble("StatisticsUpgrades", StatisticsUpgrades);
        ObscuredPrefs.SetDouble("StatisticsClicks", StatisticsClicks);
        ObscuredPrefs.SetDouble("PixlIndustryPrice", PixlIndustryPrice);
        ObscuredPrefs.SetDouble("PixlCompanyPrice", PixlCompanyPrice);
        ObscuredPrefs.SetDouble("AtomicPixlPrice", AtomicPixlPrice);
        ObscuredPrefs.SetDouble("AtomicPixlv2Price", AtomicPixlv2Price);
        ObscuredPrefs.SetDouble("QuantumPixlPrice", QuantumPixlPrice);
        ObscuredPrefs.SetDouble("QuantumPixlv2Price", QuantumPixlv2Price);
        ObscuredPrefs.SetDouble("GalaxyPixlPrice", GalaxyPixlPrice);
        ObscuredPrefs.SetDouble("AlienPixlPrice", AlienPixlPrice);
        ObscuredPrefs.SetDouble("NanoPixlPrice", NanoPixlPrice);
        ObscuredPrefs.SetDouble("VirusPixlPrice", VirusPixlPrice);
        ObscuredPrefs.SetDouble("KrytoPixlPrice", KrytoPixlPrice);
        ObscuredPrefs.SetDouble("KrytoPixlv2Price", KrytoPixlv2Price);
        ObscuredPrefs.SetDouble("UranPixlPrice", UranPixlPrice);
        ObscuredPrefs.SetDouble("PlutoniumPixlPrice", PlutoniumPixlPrice);
        ObscuredPrefs.SetFloat("Time", Time);
        ObscuredPrefs.SetFloat("MaxTimeFix", MaxTimeFix);
        ObscuredPrefs.SetFloat("TimeBought", TimeBought);
        ObscuredPrefs.SetInt("Code1", Promos.Code1);
        ObscuredPrefs.SetInt("Code2", Promos.Code2);
        ObscuredPrefs.SetInt("Code3", Promos.Code3);
        ObscuredPrefs.SetInt("Code4", Promos.Code4);
        ObscuredPrefs.SetInt("Code5", Promos.Code5);
        ObscuredPrefs.SetInt("Code6", Promos.Code6);
        ObscuredPrefs.SetInt("Code7", Promos.Code7);
        ObscuredPrefs.SetInt("Code8", Promos.Code8);
        ObscuredPrefs.SetInt("Code9", Promos.Code9);
        ObscuredPrefs.SetInt("Code10", Promos.Code10);
        ObscuredPrefs.SetInt("Code11", Promos.Code11);
        ObscuredPrefs.SetInt("Code12", Promos.Code12);
        ObscuredPrefs.SetInt("Code13", Promos.Code13);
        ObscuredPrefs.SetInt("Code14", Promos.Code14);
        ObscuredPrefs.SetInt("Code15", Promos.Code15);
        ObscuredPrefs.SetInt("Code16", Promos.Code16);
        ObscuredPrefs.SetInt("Code17", Promos.Code17);
        ObscuredPrefs.SetInt("Code18", Promos.Code18);
        ObscuredPrefs.SetBool("WelcomerOnceOpened", WelcomerOnceOpened);
        ObscuredPrefs.SetInt("ChangelogOnceOpened", ChangelogOnceOpened);
        ObscuredPrefs.SetInt("PlayedTime", PlayTimeRewards.PlayedTime);
        ObscuredPrefs.SetInt("RewardTime", PlayTimeRewards.RewardTime);
        ObscuredPrefs.SetDouble("PowerUpPixls", PowerUps.PowerUpPixls);
        ObscuredPrefs.SetInt("Timer1", PowerUps.Timer1);
        ObscuredPrefs.SetBool("Timer1On", PowerUps.Timer1On);
        ObscuredPrefs.SetDouble("PixlsReward", Achievements.PixlsReward);
        ObscuredPrefs.SetDouble("PSReward", Achievements.PSReward);
        ObscuredPrefs.SetDouble("RankReward", Achievements.RankReward);
        ObscuredPrefs.SetDouble("Statistic_Achievements", Statistic_Achievements);
        ObscuredPrefs.SetDouble("BoughtHazard1", BoughtHazard1);
        ObscuredPrefs.SetDouble("BoughtHell1", BoughtHell1);
        ObscuredPrefs.SetInt("UsedSkin", UsedSkin);
        ObscuredPrefs.SetDouble("OfflineMulti", OfflineMulti);
    }*/
}
