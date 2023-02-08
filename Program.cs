using System;

//Exercicio Média 1
double N1 = double.Parse(Console.ReadLine());
double N2 = double.Parse(Console.ReadLine());
double Media = ((N1 * 3.5) + (N2 * 7.5)) /11;
Media /= 10;

Console.WriteLine($"MEDIA = {Math.Round(Media,5)}");



//Exercicio Produto Simples
/*
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int Prod = X * Y;

Console.WriteLine($"PROD = {Prod}");



//Exercicio Área do Círculo
/*
double N = 3.14159;
double raio = double.Parse(Console.ReadLine());
double area = N * (raio * raio);

Console.WriteLine($"A = {area.ToString("F0")}");



//Exercicio Soma
/*
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int X = A + B;

Console.WriteLine($"X = {X}");



//Exércicio Hello Worl
/*
Console.WriteLine("Hello World!");
*/