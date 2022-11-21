using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSzamla
{
    internal class szamlak
    {
        int id;
        string tulajNev;
        decimal egyenleg;
        MySqlDateTime datum;

       

        public int Id { get => id; set => id = value; }
        public string TulajNev { get => tulajNev; set => tulajNev = value; }
        public decimal Egyenleg { get => egyenleg; set => egyenleg = value; }
        public MySqlDateTime Datum { get => datum; set => datum = value; }

        public szamlak(int id, string tulajNev, decimal egyenleg, MySqlDateTime datum)
        {
            this.id = id;
            this.tulajNev = tulajNev;
            this.egyenleg = egyenleg;
            this.datum = datum;
        }

        public override string ToString()
        {
            return tulajNev + " - " + egyenleg+"Ft" + " - (" + datum + ")";
        }

    }
}
