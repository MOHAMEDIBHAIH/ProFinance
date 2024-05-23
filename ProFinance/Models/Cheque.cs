using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFinance.Models
{
    public class Cheque
    {
        public string Type { get; set; }
        public string Carnet { get; set; }
        public string Société { get; set; }
        public string Banque { get; set; }
        public string Compte { get; set; }
        public string N_de_Chéque { get; set; }
        public string Date { get; set; }
        public string Delai_de_Paiement { get; set; }
        public string Bénéficiaires { get; set; }
        public string Montant { get; set; }
        public string Référence { get; set; }
        public string Remis { get; set; }
    }


}
