public abstract class Shape //Abstract due to abstract methods
{
    private string _color;
    public Shape(string color) //Simple constructor to set color
    {
        _color = color;
    }
    //Getters
    public string GetColor() //Getter for color
    {
        return _color;
    }
    public abstract double GetArea(); //Getter for Area. Required to be defined in inherited classes, left unspecified beyond outputting a double.
    //Setters
    public void SetColor(string color) //Setter for color
    {
        _color = color;
    }
}