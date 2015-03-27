using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.IO; 



namespace ListaFuncionarios
{
    public partial class Form1 : Form
    {
        List<string> lines = new List<string>(); 
        
        
        public Form1()
        {
            InitializeComponent();
            ComboBox(); 
        }




        public void ComboBox()
        {
            comboBox1.Items.Add("Feminino");
            comboBox1.Items.Add("Masculino");
            comboBox2.Items.Add("Casado(a)");
            comboBox2.Items.Add("Solteiro(a)");
            comboBox2.Items.Add("Viúvo(a)");
            comboBox2.Items.Add("Divorciado(a)");
            comboBox3.Items.Add("0");
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("Mais de 2");
        }
        
        
        
        private void adicionar(object sender, EventArgs e)
        {
           Funcionario Funci = new Funcionario(nome.Text, idade.Text, profissao.Text, salario.Text,
                tiposanguineo.Text, telefone.Text, endereco.Text, email.Text, comboBox1.Text, comboBox2.Text, 
               comboBox3.Text);

           string line = Funci.asString();
           lines.Add(Funci.asString());
            listBox1.Items.Add(Funci.asString());
            
         
        }

        private void remover(object sender, EventArgs e)
        {

            listBox1.Items.RemoveAt(0);
            lines.RemoveAt(0); 
      

        }

        private void salvar(object sender, EventArgs e)
        {

            using (System.IO.StreamWriter File = new System.IO.StreamWriter(@"C:\Users\Thais.Alves.NAVE0\Desktop\Funcionarios.txt"))
                foreach (string line in lines)
                {
                    File.WriteLine(line); 
                } 
            
  
        }

   

      
    }
}
