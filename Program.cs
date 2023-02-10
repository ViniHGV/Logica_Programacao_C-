using System;

//Exércicio da Tabuada
int N = int.Parse(Console.ReadLine());

for (int x =1 ; x <= 10; x++)
{
    Console.WriteLine($"{x} x {N} = {x*N}");
}



//Exércicio Números Positivos
/*
int num = 0;
int pos = 0;

for (int cont = 0; cont < 6; cont++){
    num = int.Parse(Console.ReadLine());
    if (num>0){
        pos++;
    }
}

Console.WriteLine($"{pos} valores positivos");




//Exercício Números pares
/*
int cont = 1;
int par = 2;

for (cont = 1; cont <= 100; cont++)
{
    if (cont % par == 0)
    {
        Console.WriteLine(cont);
    }
}




//Exercício Imposto de Renda
/
double Sal = double.Parse(Console.ReadLine());
double Imposto = 0;
double Sobra = 0;
double Porc = 0;

if (Sal >= 0 && Sal <= 2000)
{
    Console.WriteLine("Isento");
}
else if (Sal >= 2000 && Sal <= 3000)
{
    Sal -= 2000;
    Imposto = Sal * 0.08;
    Console.WriteLine($"R$ {Math.Round(Imposto,2)}");
}
else if (Sal >= 3000 && Sal <= 4500)
{
    
    Sal -= 2000;
    Sobra = (Sal - 1000);
    Porc = (Sal - 1000) * 0.18;
    Imposto = ((Sal - Sobra) * 0.08) + Porc;

    Console.WriteLine($"R$ {Math.Round(Imposto,2)}");
}




//Exercício Aumento de Salário

double Salario = double.Parse(Console.ReadLine());
double Perc = 0;

if (Salario >= 0 && Salario <= 400)
{
    Perc = Salario * 0.15;
    Salario += Perc;

    Console.WriteLine($"Novo Salario: {Math.Round(Salario, 2)}\nReajuste ganho: {Math.Round(Perc, 2)}\nEm percentual: 15 %");
}
else if (Salario > 400 && Salario <= 800)
{
    Perc = Salario * 0.12;
    Salario += Perc;

    Console.WriteLine($"Novo Salario: {Math.Round(Salario, 2)}\nReajuste ganho: {Math.Round(Perc, 2)}\nEm percentual: 12 %");
}
else if (Salario > 800 && Salario <= 1200)
{
    Perc = Salario * 0.10;
    Salario += Perc;

    Console.WriteLine($"Novo Salario: {Math.Round(Salario, 2)}\nReajuste ganho: {Math.Round(Perc, 2)}\nEm percentual: 10 %");
}
else if (Salario > 1200 && Salario <= 2000)
{
    Perc = Salario * 0.07;
    Salario += Perc;

    Console.WriteLine($"Novo Salario: {Math.Round(Salario, 2)}\nReajuste ganho: {Math.Round(Perc, 2)}\nEm percentual: 7 %");
}
else if (Salario > 2000)
{
    Perc = Salario * 0.04;
    Salario += Perc;

    Console.WriteLine($"Novo Salario: {Math.Round(Salario, 2)}\nReajuste ganho: {Math.Round(Perc, 2)}\nEm percentual: 4 %");
}
else
{
    Console.WriteLine("Não é possível a entrada de um Salário negativo !s");
}



//Exercicio Múltiplos

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if (B % A == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}



//Exercicio Média 3

double N1 = 0;
double N2 = 0;
double N3 = 0;
double N4 = 0;
double Media = 0;

do
{
    N1 = double.Parse(Console.ReadLine());
    if (N1 < 0 || N1 > 10)
    {
        Console.WriteLine("Nota inválida, só são aceitas notas de 0 a 10 !");
    }
} while (N1 < 0 || N1 > 10);

do
{
    N2 = double.Parse(Console.ReadLine());
    if (N2 < 0 || N2 > 10)
    {
        Console.WriteLine("Nota inválida, só são aceitas notas de 0 a 10 !");
    }
} while (N2 < 0 || N2 > 10);

do
{
    N3 = double.Parse(Console.ReadLine());
    if (N3 < 0 || N3 > 10)
    {
        Console.WriteLine("Nota inválida, só são aceitas notas de 0 a 10 !");
    }
} while (N3 < 0 || N3 > 10);

do
{
    N4 = double.Parse(Console.ReadLine());
    if (N4 < 0 || N4 > 10)
    {
        Console.WriteLine("Nota inválida, só são aceitas notas de 0 a 10 !");
    }
} while (N4 < 0 || N4 > 10);

Media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;

if (Media >= 7 && Media <= 10)
{
    Console.WriteLine($"Media: {Math.Round(Media, 1)}\nAluno aprovado.");
}
else if (Media >= 0 && Media < 5)
{
    Console.WriteLine($"Media: {Math.Round(Media, 1)}\nAluno reprovado.");
}
else
{
    Console.WriteLine($"Media: {Math.Round(Media, 1)}\nAluno em exame.");
    double Exame = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {Math.Round(Exame, 1)}");
    Media = (Media + Exame) / 2;
    if (Media >= 5)
    {
        Console.WriteLine($"Aluno aprovado.\nMedia final: {Math.Round(Media, 1)}");
    }
    else
    {
        Console.WriteLine($"Aluno reprovado.\nMedia final: {Math.Round(Media, 1)}");
    }

}




//Exercicio Lanche

int cod = int.Parse(Console.ReadLine());
int qtd = int.Parse(Console.ReadLine());
double Price = 0;

if (cod == 1)
{
    Price = 4.00;
    Price *= qtd;

    Console.WriteLine($"Total: R$ {Math.Round(Price, 2)}");
}
else if (cod == 2)
{
    Price = 4.50;
    Price *= qtd;

    Console.WriteLine($"Total: R$ {Math.Round(Price, 2)}");
}
else if (cod == 3)
{
    Price = 5.00;
    Price *= qtd;

    Console.WriteLine($"Total: R$ {Math.Round(Price, 2)}");
}
else if (cod == 4)
{
    Price = 2.00;
    Price *= qtd;

    Console.WriteLine($"Total: R$ {Math.Round(Price, 2)}");
}
else if (cod == 5)
{
    Price = 1.50;
    Price *= qtd;

    Console.WriteLine($"Total: R$ {Math.Round(Price, 2)}");
}
else
{
    Console.WriteLine("Código invalido");
}




//Exercicio Intervalo

double Val = double.Parse(Console.ReadLine());

if (Val > 0 && Val <= 25)
{
    Console.WriteLine("Intervalo (0,25]");
}
else if (Val > 25 && Val <= 50)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (Val > 50 && Val <= 75)
{
    Console.WriteLine("Intervalo (50,75]");
}
else if (Val > 75 && Val <= 100)
{
    Console.WriteLine("Intervalo (75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo");
}



//Exercicio Salário com Bônus

string Nome = Console.ReadLine();
double SalFix = double.Parse(Console.ReadLine());
double Vendas = double.Parse(Console.ReadLine());
double SalTotal = SalFix + (Vendas * 0.15);

Console.WriteLine($"TOTAL = R$ {Math.Round(SalTotal,2)}");




//Exercicio Salário

int num = int.Parse(Console.ReadLine());
int QtdH = int.Parse(Console.ReadLine());
double Sal = double.Parse(Console.ReadLine());
double SalTot = QtdH * Sal;

Console.WriteLine($"NUMBER = {num}\nSALARY = U$ {Math.Round(SalTot,2)}");


//Exercicio Diferença

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());
int Diferenca = (A * B - C * D);

Console.WriteLine($"DIREFENCA = {Diferenca}");



//Exercicio Média 2

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

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int Prod = X * Y;

Console.WriteLine($"PROD = {Prod}");



//Exercicio Área do Círculo

double N = 3.14159;
double raio = double.Parse(Console.ReadLine());
double area = N * (raio * raio);

Console.WriteLine($"A = {area.ToString("F0")}");



//Exercicio Soma

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int X = A + B;

Console.WriteLine($"X = {X}");



//Exércicio Hello Worl

Console.WriteLine("Hello World!");
*/