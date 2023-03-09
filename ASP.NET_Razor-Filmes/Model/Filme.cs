﻿using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;

        [DataType(DataType.Date)] public DateTime DataLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public decimal Preco { get; set; }


    }
}
