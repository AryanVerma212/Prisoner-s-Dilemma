using UnityEngine;
using System;

public class GameManager : MonoBehaviour{
    public static int roundNumber = 1;
    public static int totalRounds = 6;
    public static int player1Groundwater = 0;
    public static int player2Groundwater = 0;
    public static int player1Score = 200;
    public static int player2Score = 200;
    public static int player1Infra = 0;
    public static int player2Infra = 0;


    

    public static Card RH=new Card(0, "Rooftop Rainwater Harvesting","Your Roof, Your Water Source",
                                        "Turn your rooftop into a mini water reservoir! This technique collects rainwater from your roof and stores it in tanks for later use. Think of it like a personal rainwater barrel, providing a sustainable water source.");
    public static Card card2=new Card(1, "Spring Revival","Spring Recharge", 
                                        "Imagine bringing back the sparkle to hidden springs! This technique clears debris and restores the natural flow of freshwater springs in hilly areas. Think of it like giving springs a health check, ensuring clean and reliable water for communities that depend on them.");
    public static Card IRR=new Card(2, "Optimising Irrigation (Drip, Sprinkler)","Saving Every Drop",
                                        "This technique uses water-saving methods like drip irrigation or sprinklers to deliver water directly to plant roots. Think of it like giving your plants a personalized hydration system, minimizing water waste compared to traditional methods.");
    public static Card GR=new Card(3, "Groundwater Recharge","Replenishing Hidden Reservoir",
                                        "Give the earth a water boost! This technique involves directing rainwater or treated wastewater back into the ground. Think of it like refilling the earth's natural water storage tank, ensuring a sustainable water supply.");
    public static Card card5=new Card(4, "Paar System","Giant Sponge",
                                        "A specially designated area with sandy soil to collect rainwater. As the water filters through the sand, it becomes clean and gets stored underground. Shallow wells act like straws poking into it. Just pull the well handle, and boom! Instant hydration!");
    public static Card SYR=new Card(5, "Rainwater Syringe Technique","Injecting rainwater deep underground!",
                                        "Imagine giant water tanks catching the monsoon's bounty! It involves building special ponds and tanks to store rainwater. Think of it like a personal reservoir for your village, ready to keep everyone hydrated during those scorching summer months.");
    public static Card MZP=new Card(6, "Mazhapolima","Freshwater Lens",
                                        "This clever technique collects rainwater from rooftops and filters it through sand and gravel before directing it into open wells. Perfect for lowland and midland areas, with Ample Rainfall such that households can easily direct rainwater to open wells");
    public static Card FLD=new Card(7, "Flood-based Farming Systems","Floodwater FOR your crops!",
                                        "This technique utilizes the natural flow of floodwaters for irrigation and groundwater recharge. Think of it like letting nature do the heavy lifting during the rainy season, enriching your soil and supporting agriculture in flood-prone areas.");
    public static Card card9=new Card(8, "Dongs","Beyond the river banks",
                                        "When rivers and streams overflow their banks, these embankments capture and store this excess water, which would otherwise cause damage and erosion. They channelize river water for agricultural purposes");
    public static Card CNL=new Card(9, "Canal Lining","Lining the Way for Efficiency",
                                        "Imagine giving canals a water-saving upgrade! This technique involves using special materials to reduce water seepage from irrigation canals. Think of it like putting a protective layer on your canals, ensuring more water reaches your crops and minimizes waste.");
    public static Card ICE=new Card(10, "Ice Stupa","Ice Cones",
                                        "Imagine storing winter snow as ice for later use! This technique involves building conical structures from ice and straw in high-altitude areas. Think of it like giant ice sculptures that slowly melt and provide freshwater during dry seasons in the mountains");
    public static Card card12=new Card(11, "Chal & Khal","Water Harvesters",
                                        "These small ponds are built on mountainsides to collect rainwater! This traditional technique helps store water for various uses in hilly regions. Think of it like a natural water storage system for mountain communities, providing water for domestic use, irrigation, and wildlife.");



    public static Region Punjab = new Region(0, "Punjab (Agricultural)", 60, new int[]{2,1,3,3,1,2,1,1,1,3,1,1});
    public static Region Himachal = new Region(1, "Himachal (Himalayan)", 218, new int[]{2,3,2,1,1,1,1,1,2,2,3,3});
    public static Region Kerala = new Region(2, "Kerala (Coastal)", 194, new int[]{3,1,2,1,1,3,3,1,1,1,1,1});
    public static Region Assam = new Region(3, "Assam (Plains)", 812, new int[]{1,2,2,2,1,1,1,2,2,1,1,2});
    public static Region Karnataka = new Region(4, "Karnataka (Plateau)", 120, new int[]{3,1,3,2,1,2,2,1,1,1,1,1});
    public static Region Rajasthan = new Region(5, "Rajasthan (Desert)", 66, new int[]{2,1,3,3,3,1,1,1,1,3,1,1});

    public static Set set1 = new Set(Punjab, Kerala, new Card[]{CNL,SYR,FLD,MZP,RH,FLD,IRR,CNL,GR,MZP,CNL,SYR,
                                                                IRR,FLD,SYR,RH,MZP,GR,CNL,SYR,IRR,GR,RH,FLD});
    public static Set set2 = new Set(Himachal, Karnataka, new Card[]{GR,ICE,IRR,RH,GR,ICE,IRR,RH,GR,ICE,IRR,RH,
                                                                    GR,ICE,IRR,RH,GR,ICE,IRR,RH,GR,ICE,IRR,RH,});

    //public static Set set3 = new Set(Kerala, Assam, new Card[]{RH,SYR,MZP,IRR,FLD,GR,CNL}, new Card[]{IRR,GR,CNL,SYR,RH,MZP,FLD});

    public static Set[] sets = {set1, set2};
    public static Set currentSet;
    public static Card[] cards;
    public static Region player1Region;
    public static Region player2Region;
    public static int[,] choices;
    public static Card[] currentRoundCards;
    public static int[,] currentRoundScore;
}