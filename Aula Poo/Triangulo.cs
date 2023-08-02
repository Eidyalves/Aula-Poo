public class Triangulo
{
    public double a;
    public double b;
    public double c;
    public double p;
    public double area;

    public void CalcularAreaTriangulo()
    {
        p = (a + b + c) / 2;
        area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}