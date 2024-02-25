using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

namespace Application;

public class Circulo 
{
    public static double Perimetro(double radio)
    {
        double perimetro = 2*radio*3.1415;
        return perimetro;
    }
    public static double Area(double radio)
    { 
        double area = 3.1415*radio*radio;
        return area;
    }
    public static double Volumen(double radio)
    {
        double volumen = 4/3*3.1415*radio*radio;
        return volumen;
    }
}