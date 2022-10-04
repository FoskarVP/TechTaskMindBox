using TechTaskMindBox.Figure;

Figure circle = new Circle(1.2);
Figure triangle = new Triangel(2, 3, 3);
Figure righttriangle = new Triangel(3, 4, 5);

Console.WriteLine("Circle: " + circle.GetSquare());
Console.WriteLine($"Triangle1: {triangle.GetSquare()}. IsRighttriangel: {((Triangel)triangle).IsRightangel()}");
Console.WriteLine($"Triangle2: {righttriangle.GetSquare()}. IsRighttriangel: {((Triangel)righttriangle).IsRightangel()}");