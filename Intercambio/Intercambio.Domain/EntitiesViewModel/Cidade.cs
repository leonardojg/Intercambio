using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercambio.Domain.EntitiesViewModel
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
