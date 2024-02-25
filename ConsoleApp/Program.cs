double radio = 5;
double altura = 10;
double Perimetro = Application.Circulo.Perimetro(radio); 
double Area = Application.Circulo.Area(radio);
double Volumen = Application.Cilindro.Volumen(radio,altura);

Console.WriteLine($"El perimetro de un circulo de radio {radio}cm por PI es {Perimetro}cm");
Console.WriteLine($"El área de la base de un cilindro de radio de {radio}cm por 4/3 por PI es {Area}cm2");
Console.WriteLine($"El volumen de un cilindro con un area de la base de  {Area}cm2 y {altura}cm de altura es {Volumen}cm3");