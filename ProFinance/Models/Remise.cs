using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFinance.Models
{
    public class Remise
    {
        public string Type { get; set; }
        public string Numéro { get; set; }
        public string Date { get; set; }
        public string Montant { get; set; }
        public string Compte_de_dépôt { get; set; }
        public string Remis_par { get; set; }
        public string Nombre { get; set; }
    }
}
