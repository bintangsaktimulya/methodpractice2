double result  = 0;

double circle(double radius, double pi= 3.14)
{
    return pi * radius * radius;
}

double square(double side)
{
    return side * side;
}

double rectangle (double width, double height)
{
    return width * height ;
}

double triangle(double basse, double height)
{
    return basse * height/2;
}

Console.WriteLine($"the result of the circle {circle(3)}");
Console.WriteLine($"the result of the square {square(5)}");
Console.WriteLine($"the result of the rectangle {rectangle(4, 6)}");
Console.WriteLine($"the result of the triangle {triangle(9, 6)}");