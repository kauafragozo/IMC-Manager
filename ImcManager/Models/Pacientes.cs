using System;

namespace IMCManager.Models

{

    public class Paciente
    {

        public int PID { get; private set; }
        public string PNome { get; set; }
        public string PClasse { get; set; }
        public string PObjetivo { get; set; }
        public decimal PPeso { get; set; }
        public decimal PAltura { get; set; }
        public decimal PImc { get; set; }
        public DateTime PCad { get; set; }


    }



}