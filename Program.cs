﻿using dotNetManipulandoValores.Models;

Pessoa p1 = new()
{
    Nome = "Leonardo",
    Sobrenome = "Cardoso",
};


Curso cursoDotNet = new()
{
    Nome = "dotNet",
    Alunos = new List<Pessoa>()
};


cursoDotNet.AdicionarAluno(p1);

cursoDotNet.ListarAlunos();