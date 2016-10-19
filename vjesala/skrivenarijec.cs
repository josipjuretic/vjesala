using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraVjesala
{
    public class SkrivenaRijec
    {
        public SkrivenaRijec(string pojam)
        {
            this.pojam = pojam;
        }

        public bool ImasLiSlovo(char slovo)
        {
            throw new NotImplementedException();
            return pojam.Contains(slovo);
        }


    }
}
