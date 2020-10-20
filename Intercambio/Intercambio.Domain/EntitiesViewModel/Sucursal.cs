using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercambio.Domain.EntitiesViewModel
{
   public class Sucursal
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string NomeResponsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
    }
}
