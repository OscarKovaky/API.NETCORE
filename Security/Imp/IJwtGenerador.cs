using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Imp
{
    public interface IJwtGenerador
    {
        String CrearToken(Cliente usuario);
    }
}
