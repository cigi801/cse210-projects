public abstract class Shape
{
    private string _color; 


    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    //Constructor that accepts the color
    public Shape(string color)
    {
        _color = color;
    }

    //abstract method --allows method to be used and changed in child classes
    public abstract double GetArea();
   



}