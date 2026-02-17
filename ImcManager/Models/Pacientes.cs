using System;

namespace ImcProgram.Entities

{

    public class Paciente
    {

        public int PID { get; private set; }
        public string PNome { get; set; }
        public string PClasse { get; set; }
        public string PObjetivo { get; set; }
        public double PPeso { get; set; }
        public double PAltura { get; set; }
        public double PImc { get; set; }
        public DateTime PCad { get; set; }


    }



}