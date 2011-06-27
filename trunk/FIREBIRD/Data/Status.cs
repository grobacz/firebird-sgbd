using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    public enum Status
    {
        Disponivel = 1,
        Pendente
    }

    public class StatusUtil
    {
        public static Status ToStatus(int status)
        {
            if (status == 1)
            {
                return Status.Disponivel;
            }
            else
            {
                return Status.Pendente;
            }
        }
    }
}
