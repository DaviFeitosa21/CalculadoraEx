namespace CalculadoraEx
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
            this.txtvalores = new System.Windows.Forms.TextBox();
            this.btnum = new System.Windows.Forms.Button();
            this.btndois = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btnquatro = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btnsete = new System.Windows.Forms.Button();
            this.btnoito = new System.Windows.Forms.Button();
            this.btnnove = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvalores
            // 
            this.txtvalores.Location = new System.Drawing.Point(12, 28);
            this.txtvalores.Name = "txtvalores";
            this.txtvalores.Size = new System.Drawing.Size(250, 20);
            this.txtvalores.TabIndex = 0;
            this.txtvalores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtvalores.TextChanged += new System.EventHandler(this.txtvalores_TextChanged);
            // 
            // btnum
            // 
            this.btnum.Location = new System.Drawing.Point(12, 177);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(58, 47);
            this.btnum.TabIndex = 1;
            this.btnum.Text = "1";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // btndois
            // 
            this.btndois.Location = new System.Drawing.Point(76, 177);
            this.btndois.Name = "btndois";
            this.btndois.Size = new System.Drawing.Size(58, 47);
            this.btndois.TabIndex = 2;
            this.btndois.Text = "2";
            this.btndois.UseVisualStyleBackColor = true;
            this.btndois.Click += new System.EventHandler(this.btndois_Click);
            // 
            // btntres
            // 
            this.btntres.Location = new System.Drawing.Point(140, 177);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(58, 47);
            this.btntres.TabIndex = 3;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.btntres_Click);
            // 
            // btnquatro
            // 
            this.btnquatro.Location = new System.Drawing.Point(12, 124);
            this.btnquatro.Name = "btnquatro";
            this.btnquatro.Size = new System.Drawing.Size(58, 47);
            this.btnquatro.TabIndex = 4;
            this.btnquatro.Text = "4";
            this.btnquatro.UseVisualStyleBackColor = true;
            this.btnquatro.Click += new System.EventHandler(this.btnquatro_Click);
            // 
            // btncinco
            // 
            this.btncinco.Location = new System.Drawing.Point(76, 124);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(58, 47);
            this.btncinco.TabIndex = 5;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.btncinco_Click);
            // 
            // btnseis
            // 
            this.btnseis.Location = new System.Drawing.Point(140, 124);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(58, 47);
            this.btnseis.TabIndex = 6;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.btnseis_Click);
            // 
            // btnsete
            // 
            this.btnsete.Location = new System.Drawing.Point(12, 71);
            this.btnsete.Name = "btnsete";
            this.btnsete.Size = new System.Drawing.Size(58, 47);
            this.btnsete.TabIndex = 7;
            this.btnsete.Text = "7";
            this.btnsete.UseVisualStyleBackColor = true;
            this.btnsete.Click += new System.EventHandler(this.btnsete_Click);
            // 
            // btnoito
            // 
            this.btnoito.Location = new System.Drawing.Point(76, 71);
            this.btnoito.Name = "btnoito";
            this.btnoito.Size = new System.Drawing.Size(58, 47);
            this.btnoito.TabIndex = 8;
            this.btnoito.Text = "8";
            this.btnoito.UseVisualStyleBackColor = true;
            this.btnoito.Click += new System.EventHandler(this.btnoito_Click);
            // 
            // btnnove
            // 
            this.btnnove.Location = new System.Drawing.Point(140, 71);
            this.btnnove.Name = "btnnove";
            this.btnnove.Size = new System.Drawing.Size(58, 47);
            this.btnnove.TabIndex = 9;
            this.btnnove.Text = "9";
            this.btnnove.UseVisualStyleBackColor = true;
            this.btnnove.Click += new System.EventHandler(this.btnnove_Click);
            // 
            // btnzero
            // 
            this.btnzero.Location = new System.Drawing.Point(77, 230);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(58, 47);
            this.btnzero.TabIndex = 10;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(204, 71);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(58, 47);
            this.btnsoma.TabIndex = 11;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(204, 124);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(58, 47);
            this.btnsub.TabIndex = 12;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(204, 177);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(58, 47);
            this.btndiv.TabIndex = 13;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(205, 230);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(58, 47);
            this.btnmult.TabIndex = 14;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(141, 230);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(58, 47);
            this.btnresult.TabIndex = 15;
            this.btnresult.Text = "=";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(13, 230);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(58, 47);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "C";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.Location = new System.Drawing.Point(13, 34);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(0, 13);
            this.lbloperacao.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 288);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btnnove);
            this.Controls.Add(this.btnoito);
            this.Controls.Add(this.btnsete);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btnquatro);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btndois);
            this.Controls.Add(this.btnum);
            this.Controls.Add(this.txtvalores);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalores;
        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Button btndois;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btnquatro;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btnsete;
        private System.Windows.Forms.Button btnoito;
        private System.Windows.Forms.Button btnnove;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lbloperacao;
    }
}

