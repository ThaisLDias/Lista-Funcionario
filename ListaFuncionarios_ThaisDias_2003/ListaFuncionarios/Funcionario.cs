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

            return Nome + "" + Idade + "" + Profi + "" + TipoSang + "" + Salario + "" + Tel + "" + Ende + "" + Email + "" + Sexo + "" 
                + EstadoCivil + "" + Filhos; 
        }

        void fromString(string data)
        {
            string[] potato = data.Split(' ');
            Nome = potato[0];
            Idade = potato[1];
            Profi = potato[2];
            Salario = potato[3];
            TipoSang = potato[4];
            Tel = potato[5];
            Ende = potato[6];
            Email = potato[7];
            Sexo = potato[8];
            EstadoCivil = potato[9];
            Filhos = potato[10];
            
        }
        
    }
}
