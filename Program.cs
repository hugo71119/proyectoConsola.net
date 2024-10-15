using static System.Net.Mime.MediaTypeNames;

double pi = Math.PI;
double semiejeMenor = 5;
double semiejeMayor = 6;
double altura = 3;
double perimetro = ProyectoConsola.Application.Elipse.Perimetro(pi, semiejeMenor, semiejeMayor);
double area = ProyectoConsola.Application.Elipse.Area(pi, semiejeMenor, semiejeMayor);
double volumen = ProyectoConsola.Application.VolumenElipse.Volumen(area, altura);

Console.WriteLine($"Una elipse con semieje menor (a) de {semiejeMenor}cm y semieje mayor (b) de {semiejeMayor}cm tiene un perímetro aproximado de {perimetro}cm");
Console.WriteLine($"Una elipse con semieje menor (a) de {semiejeMenor}cm y semieje mayor (b) de {semiejeMayor}cm tiene un área aproximado de {area}cm2");
Console.WriteLine($"El volumen una elipse con un área de {area}cm2 y {altura}cm de altura es {volumen}cm3");