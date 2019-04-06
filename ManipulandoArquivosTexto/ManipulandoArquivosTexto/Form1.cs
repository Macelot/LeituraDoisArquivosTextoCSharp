using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        private string strPathFile = @"ArquivoExemplo.txt";
        private string strPathFile2 = @"ArquivoExemplo2.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Criar() {
            try
            {
                using (FileStream fs = File.Create(strPathFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("Texto adicionado ao arquivo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo criado com sucesso.");
        }

        private void Abrir()
        {
            try
            {
                if (File.Exists(strPathFile))
                {
                    System.Diagnostics.Process.Start(strPathFile);
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Concatenar()
        {
            try
            {
                if (File.Exists(strPathFile))
                {
                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        sw.Write("\r\nTexto adicionado ao final do arquivo");
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo atualizado.");
        }

        private void Alterar()
        {
            try
            {
                if (File.Exists(strPathFile))
                {
                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        sw.Write("\r\nOlá, tudo bem?");
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo alterado.");
        }

        private void Excluir()
        {
            try
            {
                if (File.Exists(strPathFile))
                {
                    File.Delete(strPathFile);
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo deletado.");
        }

        private void CriarVazio()
        {
            try
            {
                using (FileStream fs = File.Create(strPathFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo criado com sucesso.");
        }

        private void ArqDigitado()
        {
            try
            {
                using (FileStream fs = File.Create(strPathFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(txtTexto.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo criado com sucesso.");
        }

        private void CopiarConteudo()
        {
            try{
                using (StreamReader sr = new StreamReader(strPathFile))
                {
                    string[] linhas = System.IO.File.ReadAllLines(strPathFile);

                    if (File.Exists(strPathFile2))
                    {
                        using (StreamWriter sw = File.AppendText(strPathFile2))
                        {
                            foreach (string linha in linhas)
                            {
                                sw.Write("\r\n" + linha);
                            }
                        }
                        MessageBox.Show("Texto copiado com sucesso.");
                    }
                    else
                    {
                        using (FileStream fs = File.Create(strPathFile2))
                        {
                            using (StreamWriter sw = File.AppendText(strPathFile2))
                            {
                                foreach (string linha in linhas)
                                {
                                    sw.Write("\r\n" + linha);
                                }
                            }
                            MessageBox.Show("Texto copiado com sucesso.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LerPrimeiraLinha()
        {
            try
            {
                string[] linhas = System.IO.File.ReadAllLines(strPathFile);
                FileInfo arquivo = new FileInfo(strPathFile);
                MessageBox.Show("A primeira linha do arquivo " + arquivo.Name + " está escrito " + linhas[0]);
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LerUltimaLinha()
        {
            try
            {
                string[] linhas = System.IO.File.ReadAllLines(strPathFile);
                string ultima = "";
                ultima = linhas[linhas.Length - 1];
                FileInfo arquivo = new FileInfo(strPathFile);
                MessageBox.Show("A última linha do arquivo"+arquivo.Name+" está escrito "+ultima);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Comparar()
        {
            try
            {
                string[] linhas = System.IO.File.ReadAllLines(strPathFile);
                string[] linhas2 = System.IO.File.ReadAllLines(strPathFile2);

                byte[] a;
                byte[] b;

                a = System.IO.File.ReadAllBytes(strPathFile);
                b = System.IO.File.ReadAllBytes(strPathFile2);

                FileInfo f = new FileInfo(strPathFile);
                FileInfo f2 = new FileInfo(strPathFile2);
                if (BitConverter.ToString(a) == BitConverter.ToString(b))
                //if (arq1 == arq2)
                {
                    MessageBox.Show("O arquivo " + f.Name + " é igual a " + f2.Name + ".");
                }
                else
                {
                    MessageBox.Show("O arquivo " + f2.Name + " é diferente do " + f.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Criar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Concatenar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnArqVazio_Click(object sender, EventArgs e)
        {
            CriarVazio();
        }

        private void btnArqDigitado_Click(object sender, EventArgs e)
        {
            ArqDigitado();
        }

        private void btnCopiarConteudo_Click(object sender, EventArgs e)
        {
            CopiarConteudo();
        }

        private void btnLerPrimeiraLinha_Click(object sender, EventArgs e)
        {
            LerPrimeiraLinha();
        }

        private void btnLerUltimaLinha_Click(object sender, EventArgs e)
        {
            LerUltimaLinha();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            Comparar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong counter = 0;
            string line,lineBKP=""; 

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(strPathFile, Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                counter++;
                //textBox1.AppendText(line);
                lineBKP = line;
            }
            file.Close();
            MessageBox.Show("Ultima linha " + lineBKP);
            MessageBox.Show("O arquivo têm " + counter + " linhas." );
            // Suspend the screen.  
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
