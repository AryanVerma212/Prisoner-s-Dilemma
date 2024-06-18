using System;
public class Card
{
    public int id;
    public String name;
    public String description1;
    public String description2;
    public Card(int id, String name, String description1, String description2){
        this.id = id;
        this.name = name;
        this.description1 = description1;
        this.description2 = description2;
    }
}

public class Region
{
    int id;
    public String name;
    public int groundwater;
    public int[] weights;

    public Region(int id, String name, int groundwater, int[] weights){
        this.id = id;
        this.name = name;
        this.groundwater = groundwater;
        this.weights = weights;
    }
}

public class Set{
    public Region player1Region;
    public Region player2Region;
    public Card[] Cards;

    public Set(Region player1Region, Region player2Region, Card[] Cards){
        this.player1Region = player1Region;
        this.player2Region = player2Region;
        this.Cards = Cards;
    }
}
