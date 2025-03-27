using SQLite;

namespace Carros.Models
{
    public class Veiculo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Modelo { get; set; }

        public string Descricao { get; set; }

        public string Fabricacao { get; set; }

        public string Ano { get; set; }
    }
}
