using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_Projekt_1.Models {
    public interface IPerson {

        string Navn { get; set; }
        int Telefon { get; set; }
        string Email { get; set; }

    }
}
