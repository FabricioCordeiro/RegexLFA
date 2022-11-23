using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RegexLFA
{
    internal class RgxDA
    {
        public Guid Id { get; set; }
        public int Nome { get; set; }
        public string? Email { get; set; }
        public string? OutroInput { get; set; }

        public RgxDA()
        {
            string texto = "um texto";
        }


    }
}
