namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnArqVazio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnArqDigitado = new System.Windows.Forms.Button();
            this.btnCopiarConteudo = new System.Windows.Forms.Button();
            this.btnLerPrimeiraLinha = new System.Windows.Forms.Button();
            this.btnLerUltimaLinha = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(77, 45);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(130, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar arquivo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(77, 74);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(130, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(77, 103);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(130, 23);
            this.btnConcatenar.TabIndex = 2;
            this.btnConcatenar.Text = "Concatenar arquivo";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(77, 132);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar arquivo";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(77, 161);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir arquivo";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnArqVazio
            // 
            this.btnArqVazio.Location = new System.Drawing.Point(77, 190);
            this.btnArqVazio.Name = "btnArqVazio";
            this.btnArqVazio.Size = new System.Drawing.Size(130, 23);
            this.btnArqVazio.TabIndex = 5;
            this.btnArqVazio.Text = "Criar arquivo vazio";
            this.btnArqVazio.UseVisualStyleBackColor = true;
            this.btnArqVazio.Click += new System.EventHandler(this.btnArqVazio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(79, 219);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(128, 20);
            this.txtTexto.TabIndex = 7;
            // 
            // btnArqDigitado
            // 
            this.btnArqDigitado.Location = new System.Drawing.Point(77, 245);
            this.btnArqDigitado.Name = "btnArqDigitado";
            this.btnArqDigitado.Size = new System.Drawing.Size(130, 39);
            this.btnArqDigitado.TabIndex = 8;
            this.btnArqDigitado.Text = "Arquivo digitado pelo usuário";
            this.btnArqDigitado.UseVisualStyleBackColor = true;
            this.btnArqDigitado.Click += new System.EventHandler(this.btnArqDigitado_Click);
            // 
            // btnCopiarConteudo
            // 
            this.btnCopiarConteudo.Location = new System.Drawing.Point(79, 290);
            this.btnCopiarConteudo.Name = "btnCopiarConteudo";
            this.btnCopiarConteudo.Size = new System.Drawing.Size(128, 36);
            this.btnCopiarConteudo.TabIndex = 9;
            this.btnCopiarConteudo.Text = "Copiar conteúdo para outro arquivo";
            this.btnCopiarConteudo.UseVisualStyleBackColor = true;
            this.btnCopiarConteudo.Click += new System.EventHandler(this.btnCopiarConteudo_Click);
            // 
            // btnLerPrimeiraLinha
            // 
            this.btnLerPrimeiraLinha.Location = new System.Drawing.Point(79, 332);
            this.btnLerPrimeiraLinha.Name = "btnLerPrimeiraLinha";
            this.btnLerPrimeiraLinha.Size = new System.Drawing.Size(128, 23);
            this.btnLerPrimeiraLinha.TabIndex = 10;
            this.btnLerPrimeiraLinha.Text = "Ler 1ª linha";
            this.btnLerPrimeiraLinha.UseVisualStyleBackColor = true;
            this.btnLerPrimeiraLinha.Click += new System.EventHandler(this.btnLerPrimeiraLinha_Click);
            // 
            // btnLerUltimaLinha
            // 
            this.btnLerUltimaLinha.Location = new System.Drawing.Point(79, 361);
            this.btnLerUltimaLinha.Name = "btnLerUltimaLinha";
            this.btnLerUltimaLinha.Size = new System.Drawing.Size(128, 23);
            this.btnLerUltimaLinha.TabIndex = 11;
            this.btnLerUltimaLinha.Text = "Ler última linha";
            this.btnLerUltimaLinha.UseVisualStyleBackColor = true;
            this.btnLerUltimaLinha.Click += new System.EventHandler(this.btnLerUltimaLinha_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(79, 390);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(128, 23);
            this.btnComparar.TabIndex = 12;
            this.btnComparar.Text = "Comparar Tamanho";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 423);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 62);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "By William Tomé \\TM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnLerUltimaLinha);
            this.Controls.Add(this.btnLerPrimeiraLinha);
            this.Controls.Add(this.btnCopiarConteudo);
            this.Controls.Add(this.btnArqDigitado);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArqVazio);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCriar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnArqVazio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnArqDigitado;
        private System.Windows.Forms.Button btnCopiarConteudo;
        private System.Windows.Forms.Button btnLerPrimeiraLinha;
        private System.Windows.Forms.Button btnLerUltimaLinha;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

