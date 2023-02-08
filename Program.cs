using System;


//Exercicio Diferença
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());
int Diferenca = (A * B - C * D);

Console.WriteLine($"DIREFENCA = {Diferenca}");



//Exercicio Média 2
/*
double A = 0;
double B = 0;
double C = 0;
double Media = 0;

do
{
    A = double.Parse(Console.ReadLine());
    if(A < 0 || A > 10){
        Console.WriteLine("Valor invalido\nOs valores aceitos são de 0 a 10!");
    }
}while(A < 0 || A > 10 );


do
{
    B = double.Parse(Console.ReadLine());
    if(B < 0 || B > 10){
        Console.WriteLine("Valor invalido\nOs valores aceitos são de 0 a 10!");
    }
}while(B < 0 || B > 10 );


do
{
    C = double.Parse(Console.ReadLine());
    if(C < 0 || C > 10){
        Console.WriteLine("Valor invalido\nOs valores aceitos são de 0 a 10!");
    }
}while(C < 0 || C > 10 );

Media = ((A * 2) + (B * 3) + (C * 5)) /10;

Console.WriteLine($"MEDIA = {Math.Round(Media,1)}");


//Exercicio Média 1
/*
double N1 = 0;
double N2 = 0;

do
{
    N1 = double.Parse(Console.ReadLine());
    if(N1 < 0 || N1 > 10){
        Console.WriteLine("Valor invalido\nOs valores aceitos são de 0 a 10!");
    }
}while(N1 < 0 || N1 > 10 );

do
{
    N2 = double.Parse(Console.ReadLine());
    if(N2 < 0 || N2 > 10){
        Console.WriteLine("Valor invalido\nOs valores aceitos são de 0 a 10!");
    }
}while(N2 < 0 || N2 > 10 );

double Media = ((N1 * 3.5) + (N2 * 7.5)) /11;

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