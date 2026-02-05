using System;

namespace ImcProgram.Entities

{

    public class Pacientes
    {

        public int ID { get; private set; }
        public string PaNome { get; set; }
        public string PaClasse { get; set; }
        public string PaObjetivo { get; set; }
        public double PaPeso { get; set; }
        public double PaAltura { get; set; }
        public double PaImc { get; set; }
        public DateTime PaCad { get; set; }


    }



}