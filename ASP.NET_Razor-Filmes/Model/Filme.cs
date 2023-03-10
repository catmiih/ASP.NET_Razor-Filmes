using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data Lançamento")]
        [DataType(DataType.Date)] public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }


    }
}
