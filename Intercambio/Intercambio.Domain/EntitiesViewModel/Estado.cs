using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercambio.Domain.EntitiesViewModel
{
    public class Estado
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}
