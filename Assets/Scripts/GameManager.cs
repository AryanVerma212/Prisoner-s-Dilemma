using UnityEngine;

public class GameManager : MonoBehaviour{
    /*
        public Card(String name, String description, int coo_coo, int def_def, int def_coo, int coo_def){
        this.name = name;
        this.description = description;
        this.coo_coo = coo_coo;
        this.def_def = def_def;
        this.def_coo = def_coo;
        this.coo_def = coo_def;
    }
    */
    public static int roundNumber = 1;
    public static int totalRounds = 6;
    public static float player1Score = 30;
    public static float player2Score = 30;

    

    public static Card card1=new Card(0, "Rooftop Rainwater Harvesting","Rooftop Rainwater Harvesting","Description2");
    public static Card card2=new Card(1, "Spring Revival","Giving Hidden Gems a Second Life", 
                                        "This technique breathes new life into springs and streams by removing blockages and helping water flow freely again");
    public static Card card3=new Card(2, "Optimising Irrigation","Level Up Your Watering Game",
                                        "Think of it like a personalized hydration system for your crops, keeping them happy and healthy!");
    public static Card card4=new Card(3, "Crop Diversification","Switch Up your squad",
                                        "Imagine having a diverse group of friends, right? This technique is similar! Planting different crops with varying water needs helps utilize water more efficiently throughout the year. Maybe you have water-loving rice and drought-resistant lentils - all using water wisely!");
    public static Card card5=new Card(4, "Groundwater Recharge","Replenishing the Underground Treasure",
                                        "Groundwater is like hidden water savings! This technique involves soaking the earth with rainwater or excess water, creating a natural reservoir below the ground.");
    public static Card card6=new Card(5, "Talav/Eri System","Monsoon catchers",
                                        "Imagine giant water tanks catching the monsoon's bounty! It involves building special ponds and tanks to store rainwater. Think of it like a personal reservoir for your village, ready to keep everyone hydrated during those scorching summer months.");
    public static Card card7=new Card(6, "Rainwater Syringe Technique","Rainwater Syringe Technique",
                                        "This technique injects rainwater into deeper aquifers to create a freshwater lens and improve water quality specially if water nearby is a little too salty. Think of it like a giant syringe keeping your place hydrated !");
    public static Card card8=new Card(7, "Maxhapolima","Maxhapolima",
                                        "Technique using sand, gravel, and charcoal filters to direct rainwater into open wells, restoring the water table in lowland and midland areas.");
    public static Card card9=new Card(8, "Flood-based Farming Systems","Farming with the Flow",
                                        " Imagine crops growing alongside rivers! This technique utilizes seasonal floods to nourish crops in specific regions. Think of it like letting nature do the heavy lifting!");
    public static Card card10=new Card(9, "Wetland Conservation","Farming with the Flow",
                                        "Imagine crops growing alongside rivers! This technique utilizes seasonal floods to nourish crops in specific regions. Think of it like letting nature do the heavy lifting!");
    public static Card card11=new Card(10, "Dongs","Dongs", "Dongs");
    public static Card card12=new Card(11, "Canal Lining","Canal Lining",
                                        "Ever felt like canals are leaking precious water? This technique, a game-changer for agricultural regions like Punjab, involves lining canals with special materials to prevent water seepage. Think of it like giving your canals a super-suit to deliver more water to your crops!");



    public static Region region1 = new Region(0, "Punjab (Agricultural)", new int[]{3,2,4,3,4,3,2,2,2,2,2,4});
    public static Region region2 = new Region(1, "Himachal (Himalayan)", new int[]{3,4,3,2,3,2,2,2,2,2,2,2});
    public static Region region3 = new Region(2, "Kerala (Coastal)", new int[]{3,2,3,2,3,2,2,2,2,2,2,2});
    public static Region region4 = new Region(3, "West Bengal (Riverine)", new int[]{3,2,3,3,3,3,2,2,4,4,2,4});
    public static Region region5 = new Region(4, "Karnataka (Plateau)", new int[]{4,2,3,3,4,3,2,2,2,4,2,2});
    public static Region region6 = new Region(5, "Rajasthan (Desert)", new int[]{3,2,4,3,4,3,3,3,2,2,4,2});
    public static Region region7 = new Region(6, "Assam (Plains)", new int[]{4,2,3,3,3,3,2,2,3,3,4,4});

    public static Card[] cards = {card1, card2, card3, card4, card5, card6, card7, card8, card9, card10, card11, card12,
                                    card1, card2, card3, card4, card5, card6, card7, card8, card9, card10, card11, card12,};
    public static Region[] regions = {region1, region2, region3, region4, region5, region6, region7};

    public static Region[] player1Regions;
    public static Region[] player2Regions;
    public static int[,] choices;
    public static Card[] currentRoundCards;
    public static float[,] currentRoundScore;
}