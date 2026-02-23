using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using IMCManager.Services.Pacientes;
using Microsoft.Identity.Client;
using ImcManager.Services;
using IMCManager.Models;


namespace ImcManager.Services.Export
{
    public class ExportService()
    {

        public string ExportarCSV(List<Paciente> pacientes)
        {
            if (pacientes == null || pacientes.Count == 0)
            {
                Console.WriteLine("Não existem dados para exportar!");
                Console.ReadKey();
            }

            string path = Directory.GetCurrentDirectory();
            string pasta = Path.Combine(path, "Docs");

            Directory.CreateDirectory(pasta);
            string nomeArquivo = $"Pacientes{DateTime.Now:yyyyMMdd}.csv";
            string pathCompleto = Path.Combine(pasta, nomeArquivo);

            using (StreamWriter sw = new StreamWriter(pathCompleto, false, Encoding.UTF8))
            {
                sw.WriteLine("ID;Nome;Classificação;Objetivo;Peso;Altura;IMC;DataCadastro");
                foreach (var p in pacientes)
                {
                    sw.WriteLine($"{p.PID};{p.PNome};{p.PClasse};{p.PPeso};{p.PAltura};{p.PImc};{p.PCad}");
                }
            }
            return pathCompleto;
        }
    }
}