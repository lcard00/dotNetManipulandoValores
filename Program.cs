﻿using System.Globalization;
using dotNetManipulandoValores.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C3"));
Console.WriteLine(valorMonetario.ToString("N3"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P2"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));

long cpf = 08357186629;

Console.WriteLine(cpf.ToString(@"000\.000\.000\-00"));

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToString("yyyy-MM-dd"));
Console.WriteLine(data.ToShortTimeString());


DateTime d1 = DateTime.Parse("08/02/2024 22:30");

Console.WriteLine(d1);

string dataString = "2024-02-08 22:30";

Console.WriteLine(dataString);

dataString = "2024-02-32 22:35";

bool validaData = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataC);

if (validaData)
{
    Console.WriteLine(dataC);
}
else
{
    Console.WriteLine("Data inválida!");
}


















// Pessoa p1 = new()
// {
//     Nome = "Leonardo",
//     Sobrenome = "Cardoso",
// };


// Curso cursoDotNet = new()
// {
//     Nome = "dotNet",
//     Alunos = new List<Pessoa>()
// };


// cursoDotNet.AdicionarAluno(p1);

// cursoDotNet.ListarAlunos();

// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);