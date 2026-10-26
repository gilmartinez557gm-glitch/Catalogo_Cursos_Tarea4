
using System.Collections.Generic;

namespace Catalogo_Cursos_Tarea4.Models;

public static class CursosRepositorio
{
    public static List<Curso> Cursos { get; } = new()
    {
        new Curso
        {
            Id = 1,
            Nombre = "C# desde cero",
            Descripcion = "Fundamentos de programación con C#.",
            Instructor = "Ricardo Lagos",
            DuracionHoras = 20,
            Nivel = "Principiante"
        },
        new Curso
        {
            Id = 2,
            Nombre = "Desarrollo con .NET MAUI",
            Descripcion = "Creación de aplicaciones multiplataforma.",
            Instructor = "Ricardo Lagos",
            DuracionHoras = 30,
            Nivel = "Intermedio"
        },
        new Curso
        {
            Id = 3,
            Nombre = "Bases de datos SQL",
            Descripcion = "Diseño de tablas y consultas SQL.",
            Instructor = "Herbert Webster",
            DuracionHoras = 25,
            Nivel = "Principiante"
        },
        new Curso
        {
            Id = 4,
            Nombre = "Desarrollo web",
            Descripcion = "Fundamentos para crear aplicaciones web.",
            Instructor = "Ricardo Lagos",
            DuracionHoras = 35,
            Nivel = "Intermedio"
        },
        new Curso
        {
            Id = 5,
            Nombre = "Análisis de datos",
            Descripcion = "Introducción al análisis y visualización de datos.",
            Instructor = "Herbert Webster",
            DuracionHoras = 28,
            Nivel = "Intermedio"
        }
    };
}
