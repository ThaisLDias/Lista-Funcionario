using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionarios
{
    class Funcionario
    {
        public string Nome;
        public string Idade;
        public string Profi;
        public string Salario;
        public string TipoSang;
        public string Tel;
        public string Ende;
        public string Email;
        public string Sexo;
        public string EstadoCivil;
        public string Filhos;


        public Funcionario(string _Nome, string _Idade, string _Profi, string _Salario, string _TipoSang, string _Tel, string _Ende,
            string _Email, string _Sexo, string _EstadoCivil, string _Filhos)
        {
        Nome = _Nome; 
        Idade = _Idade; 
        Profi = _Profi; 
        Salario =  _Salario; 
        TipoSang = _TipoSang;  
        Tel = _Tel; 
        Ende = _Ende; 
        Email = _Email; 
        Sexo = _Sexo; 
        EstadoCivil = _EstadoCivil;
        Filhos = _Filhos;
        }

        public string asString() {

            return Nome + " " + Idade + " " + Profi + " " + TipoSang + " " + Salario + " " + Tel + " " + Ende + " " + Email + " " + Sexo + " "
                + EstadoCivil + " " + Filhos; 
        }

        void fromString(string data)
        {
            string[] potatos = data.Split(' ');
            Nome = potatos[0];
            Idade = potatos[1];
            Profi = potatos[2];
            Salario = potatos[3];
            TipoSang = potatos[4];
            Tel = potatos[5];
            Ende = potatos[6];
            Email = potatos[7];
            Sexo = potatos[8];
            EstadoCivil = potatos[9];
            Filhos = potatos[10];

          
        
        }
        
    }
}
