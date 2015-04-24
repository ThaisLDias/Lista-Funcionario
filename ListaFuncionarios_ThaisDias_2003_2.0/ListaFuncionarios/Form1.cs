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
       
        public string username = Environment.GetEnvironmentVariable("username"); 
        List<string> lines = new List<string>();
        public string[] indices;
        public string[] potatos;
        public string line;
      


        public Form1()
        {
            InitializeComponent();
            ComboBox();
            
        }




        public void ComboBox()
        {
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
                 tiposanguineo.Text, telefone.Text, endereco.Text, email.Text, groupBox1.Text, comboBox2.Text,
                comboBox3.Text);



       
            
            string line = Funci.asString();
            lines.Add(Funci.asString() + text);
            listBox1.Items.Add(Funci.Nome);

            MessageBox.Show("Funcionário cadastrado com sucesso. Clique em salvar para adicionar à lista"); 
         


        }

        private void remover(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
                lines.RemoveAt(i); 
            }
        
        }

        private void salvar(object sender, EventArgs e)
        {

            using (StreamWriter File = new StreamWriter(@"C:\Users\" + username + @"\Desktop\Funcionarios.txt", true)) 
                foreach (string line in lines)
                {
                    File.WriteLine(line);
                }


        }

        private string text = ""; 
        private void Masculino(object sender, EventArgs e)
        {
          
            pictureBox1.Image = imageList1.Images[1];
  
            if (radioButton2.Checked)
            {
                text = radioButton2.Text;
            }
             
        }

        private void Feminino(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            if (radioButton1.Checked)
            {
                text = radioButton1.Text;
            }

        }

        private void outros(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            if (radioButton3.Checked)
            {
                text = radioButton3.Text;
            }

        }

        private void Load_Click(object sender, EventArgs e)
        {

            using (StreamReader file = new StreamReader(@"C:\Users\" + username + @"\Desktop\Funcionarios.txt"))
            {
                string[] hue;
                while ((line = file.ReadLine()) != null)
                {
                    hue = line.Split(' ');
                    Console.WriteLine(hue[0]);
                    listBox1.Items.Add(hue[0]);
                   /* for (int i = 0; i <= potatos.Length - 1; i++)
                    {
                        lines.Add(potatos[i]);
                    }*/
                }
            }
           /* for (int i = 0; i < potatos.Length; i++)
            { 
                
            }*/


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indices = File.ReadAllLines(@"C:\Users\" + username + @"\Desktop\Funcionarios.txt");
            //Console.WriteLine(listBox1.SelectedIndex);
            if (listBox1.SelectedIndex >= 0)
            {
                string line = indices[listBox1.SelectedIndex];
                string[] selectedProp;
                //Console.WriteLine("rodou");
                /*for (int i = 0; i < lines.Count; i++)
                {*/

                    selectedProp = line.Split(' ');
                        nome.Text = selectedProp[0];
                        idade.Text = selectedProp[1];
                        profissao.Text = selectedProp[2];
                        tiposanguineo.Text = selectedProp[3];
                        salario.Text = selectedProp[4];
                        telefone.Text = selectedProp[5];
                        endereco.Text = selectedProp[6];
                        email.Text = selectedProp[7];
                        groupBox1.Text = selectedProp[8];
                        comboBox2.Text = selectedProp[9];
                        comboBox3.Text = selectedProp[10];

               // }
            }
        
        }


        

       
       

       



    }


}
