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
    public int[] weights;

    public Region(int id, String name, int[] weights){
        this.id = id;
        this.name = name;
        this.weights = weights;
    }
}
