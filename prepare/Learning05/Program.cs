using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes>_shape = new List<Shapes>();
        Square sq = new Square ("Blue", 5);
        _shape.Add(sq);

        Rectangle rec = new Rectangle ("Green", 3, 2);
        _shape.Add(rec);

        Circle cir = new Circle ("Red", 3);
        _shape.Add(cir);

        
         foreach(Shapes s in _shape){
            string color = s.GetColor();

            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
         }
        
    }
}