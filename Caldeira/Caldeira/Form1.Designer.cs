namespace Caldeira
{
    partial class frmCaldeira
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
            this.gpCaldeira = new System.Windows.Forms.GroupBox();
            this.txtTempCaldeira = new System.Windows.Forms.TextBox();
            this.lblNivelAguaCaldeira = new System.Windows.Forms.Label();
            this.lblTemperaturaCaldeira = new System.Windows.Forms.Label();
            this.gpFuncionario1 = new System.Windows.Forms.GroupBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.btnAdicionarAgua = new System.Windows.Forms.Button();
            this.gpFuncionario2 = new System.Windows.Forms.GroupBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnAlterarTemperatura = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNivelAguaCaldeira = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNivelAguaFunc1 = new System.Windows.Forms.TextBox();
            this.lblTempFunc1 = new System.Windows.Forms.Label();
            this.lblNivelAguaFunc1 = new System.Windows.Forms.Label();
            this.txtTempFunc1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNivelAguaFunc2 = new System.Windows.Forms.TextBox();
            this.lblTempFunc2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempFunc2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gpCaldeira.SuspendLayout();
            this.gpFuncionario1.SuspendLayout();
            this.gpFuncionario2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCaldeira
            // 
            this.gpCaldeira.Controls.Add(this.panel1);
            this.gpCaldeira.Location = new System.Drawing.Point(12, 12);
            this.gpCaldeira.Name = "gpCaldeira";
            this.gpCaldeira.Size = new System.Drawing.Size(207, 274);
            this.gpCaldeira.TabIndex = 0;
            this.gpCaldeira.TabStop = false;
            this.gpCaldeira.Text = "Caldeira";
            // 
            // txtTempCaldeira
            // 
            this.txtTempCaldeira.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempCaldeira.CausesValidation = false;
            this.txtTempCaldeira.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTempCaldeira.Enabled = false;
            this.txtTempCaldeira.Location = new System.Drawing.Point(81, 8);
            this.txtTempCaldeira.Name = "txtTempCaldeira";
            this.txtTempCaldeira.ReadOnly = true;
            this.txtTempCaldeira.ShortcutsEnabled = false;
            this.txtTempCaldeira.Size = new System.Drawing.Size(68, 20);
            this.txtTempCaldeira.TabIndex = 2;
            this.txtTempCaldeira.TabStop = false;
            this.txtTempCaldeira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempCaldeira.WordWrap = false;
            // 
            // lblNivelAguaCaldeira
            // 
            this.lblNivelAguaCaldeira.AutoSize = true;
            this.lblNivelAguaCaldeira.Location = new System.Drawing.Point(3, 34);
            this.lblNivelAguaCaldeira.Name = "lblNivelAguaCaldeira";
            this.lblNivelAguaCaldeira.Size = new System.Drawing.Size(78, 13);
            this.lblNivelAguaCaldeira.TabIndex = 1;
            this.lblNivelAguaCaldeira.Text = "Nível da água:";
            // 
            // lblTemperaturaCaldeira
            // 
            this.lblTemperaturaCaldeira.AutoSize = true;
            this.lblTemperaturaCaldeira.Location = new System.Drawing.Point(3, 11);
            this.lblTemperaturaCaldeira.Name = "lblTemperaturaCaldeira";
            this.lblTemperaturaCaldeira.Size = new System.Drawing.Size(70, 13);
            this.lblTemperaturaCaldeira.TabIndex = 0;
            this.lblTemperaturaCaldeira.Text = "Temperatura:";
            // 
            // gpFuncionario1
            // 
            this.gpFuncionario1.Controls.Add(this.panel4);
            this.gpFuncionario1.Controls.Add(this.panel2);
            this.gpFuncionario1.Location = new System.Drawing.Point(225, 12);
            this.gpFuncionario1.Name = "gpFuncionario1";
            this.gpFuncionario1.Size = new System.Drawing.Size(303, 226);
            this.gpFuncionario1.TabIndex = 2;
            this.gpFuncionario1.TabStop = false;
            this.gpFuncionario1.Text = "Funcionário 1 - Água";
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(3, 19);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(86, 20);
            this.txtAgua.TabIndex = 3;
            this.txtAgua.TextChanged += new System.EventHandler(this.txtAgua_TextChanged);
            // 
            // btnAdicionarAgua
            // 
            this.btnAdicionarAgua.Location = new System.Drawing.Point(95, 10);
            this.btnAdicionarAgua.Name = "btnAdicionarAgua";
            this.btnAdicionarAgua.Size = new System.Drawing.Size(112, 36);
            this.btnAdicionarAgua.TabIndex = 2;
            this.btnAdicionarAgua.Text = "Alterar Nível da Água";
            this.btnAdicionarAgua.UseVisualStyleBackColor = true;
            this.btnAdicionarAgua.Click += new System.EventHandler(this.btnAdicionarAgua_Click);
            // 
            // gpFuncionario2
            // 
            this.gpFuncionario2.Controls.Add(this.panel5);
            this.gpFuncionario2.Controls.Add(this.panel3);
            this.gpFuncionario2.Location = new System.Drawing.Point(534, 12);
            this.gpFuncionario2.Name = "gpFuncionario2";
            this.gpFuncionario2.Size = new System.Drawing.Size(303, 226);
            this.gpFuncionario2.TabIndex = 2;
            this.gpFuncionario2.TabStop = false;
            this.gpFuncionario2.Text = "Funcionário 2 - Fogo";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(3, 17);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(86, 20);
            this.txtTemperatura.TabIndex = 4;
            // 
            // btnAlterarTemperatura
            // 
            this.btnAlterarTemperatura.Location = new System.Drawing.Point(95, 8);
            this.btnAlterarTemperatura.Name = "btnAlterarTemperatura";
            this.btnAlterarTemperatura.Size = new System.Drawing.Size(112, 36);
            this.btnAlterarTemperatura.TabIndex = 3;
            this.btnAlterarTemperatura.Text = "Alterar Temperatura do Fogo";
            this.btnAlterarTemperatura.UseVisualStyleBackColor = true;
            this.btnAlterarTemperatura.Click += new System.EventHandler(this.btnAlterarTemperatura_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNivelAguaCaldeira);
            this.panel1.Controls.Add(this.lblTemperaturaCaldeira);
            this.panel1.Controls.Add(this.lblNivelAguaCaldeira);
            this.panel1.Controls.Add(this.txtTempCaldeira);
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 66);
            this.panel1.TabIndex = 3;
            // 
            // txtNivelAguaCaldeira
            // 
            this.txtNivelAguaCaldeira.BackColor = System.Drawing.SystemColors.Info;
            this.txtNivelAguaCaldeira.CausesValidation = false;
            this.txtNivelAguaCaldeira.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNivelAguaCaldeira.Enabled = false;
            this.txtNivelAguaCaldeira.Location = new System.Drawing.Point(81, 31);
            this.txtNivelAguaCaldeira.Name = "txtNivelAguaCaldeira";
            this.txtNivelAguaCaldeira.ReadOnly = true;
            this.txtNivelAguaCaldeira.ShortcutsEnabled = false;
            this.txtNivelAguaCaldeira.Size = new System.Drawing.Size(68, 20);
            this.txtNivelAguaCaldeira.TabIndex = 3;
            this.txtNivelAguaCaldeira.TabStop = false;
            this.txtNivelAguaCaldeira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNivelAguaCaldeira.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNivelAguaFunc1);
            this.panel2.Controls.Add(this.lblTempFunc1);
            this.panel2.Controls.Add(this.lblNivelAguaFunc1);
            this.panel2.Controls.Add(this.txtTempFunc1);
            this.panel2.Location = new System.Drawing.Point(6, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 66);
            this.panel2.TabIndex = 4;
            // 
            // txtNivelAguaFunc1
            // 
            this.txtNivelAguaFunc1.BackColor = System.Drawing.SystemColors.Info;
            this.txtNivelAguaFunc1.CausesValidation = false;
            this.txtNivelAguaFunc1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNivelAguaFunc1.Enabled = false;
            this.txtNivelAguaFunc1.Location = new System.Drawing.Point(81, 31);
            this.txtNivelAguaFunc1.Name = "txtNivelAguaFunc1";
            this.txtNivelAguaFunc1.ReadOnly = true;
            this.txtNivelAguaFunc1.ShortcutsEnabled = false;
            this.txtNivelAguaFunc1.Size = new System.Drawing.Size(68, 20);
            this.txtNivelAguaFunc1.TabIndex = 3;
            this.txtNivelAguaFunc1.TabStop = false;
            this.txtNivelAguaFunc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNivelAguaFunc1.WordWrap = false;
            // 
            // lblTempFunc1
            // 
            this.lblTempFunc1.AutoSize = true;
            this.lblTempFunc1.Location = new System.Drawing.Point(3, 11);
            this.lblTempFunc1.Name = "lblTempFunc1";
            this.lblTempFunc1.Size = new System.Drawing.Size(70, 13);
            this.lblTempFunc1.TabIndex = 0;
            this.lblTempFunc1.Text = "Temperatura:";
            // 
            // lblNivelAguaFunc1
            // 
            this.lblNivelAguaFunc1.AutoSize = true;
            this.lblNivelAguaFunc1.Location = new System.Drawing.Point(3, 34);
            this.lblNivelAguaFunc1.Name = "lblNivelAguaFunc1";
            this.lblNivelAguaFunc1.Size = new System.Drawing.Size(78, 13);
            this.lblNivelAguaFunc1.TabIndex = 1;
            this.lblNivelAguaFunc1.Text = "Nível da água:";
            // 
            // txtTempFunc1
            // 
            this.txtTempFunc1.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempFunc1.CausesValidation = false;
            this.txtTempFunc1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTempFunc1.Enabled = false;
            this.txtTempFunc1.Location = new System.Drawing.Point(81, 8);
            this.txtTempFunc1.Name = "txtTempFunc1";
            this.txtTempFunc1.ReadOnly = true;
            this.txtTempFunc1.ShortcutsEnabled = false;
            this.txtTempFunc1.Size = new System.Drawing.Size(68, 20);
            this.txtTempFunc1.TabIndex = 2;
            this.txtTempFunc1.TabStop = false;
            this.txtTempFunc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempFunc1.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNivelAguaFunc2);
            this.panel3.Controls.Add(this.lblTempFunc2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTempFunc2);
            this.panel3.Location = new System.Drawing.Point(6, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 66);
            this.panel3.TabIndex = 4;
            // 
            // txtNivelAguaFunc2
            // 
            this.txtNivelAguaFunc2.BackColor = System.Drawing.SystemColors.Info;
            this.txtNivelAguaFunc2.CausesValidation = false;
            this.txtNivelAguaFunc2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNivelAguaFunc2.Enabled = false;
            this.txtNivelAguaFunc2.Location = new System.Drawing.Point(81, 31);
            this.txtNivelAguaFunc2.Name = "txtNivelAguaFunc2";
            this.txtNivelAguaFunc2.ReadOnly = true;
            this.txtNivelAguaFunc2.ShortcutsEnabled = false;
            this.txtNivelAguaFunc2.Size = new System.Drawing.Size(68, 20);
            this.txtNivelAguaFunc2.TabIndex = 3;
            this.txtNivelAguaFunc2.TabStop = false;
            this.txtNivelAguaFunc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNivelAguaFunc2.WordWrap = false;
            // 
            // lblTempFunc2
            // 
            this.lblTempFunc2.AutoSize = true;
            this.lblTempFunc2.Location = new System.Drawing.Point(3, 11);
            this.lblTempFunc2.Name = "lblTempFunc2";
            this.lblTempFunc2.Size = new System.Drawing.Size(70, 13);
            this.lblTempFunc2.TabIndex = 0;
            this.lblTempFunc2.Text = "Temperatura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nível da água:";
            // 
            // txtTempFunc2
            // 
            this.txtTempFunc2.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempFunc2.CausesValidation = false;
            this.txtTempFunc2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTempFunc2.Enabled = false;
            this.txtTempFunc2.Location = new System.Drawing.Point(81, 8);
            this.txtTempFunc2.Name = "txtTempFunc2";
            this.txtTempFunc2.ReadOnly = true;
            this.txtTempFunc2.ShortcutsEnabled = false;
            this.txtTempFunc2.Size = new System.Drawing.Size(68, 20);
            this.txtTempFunc2.TabIndex = 2;
            this.txtTempFunc2.TabStop = false;
            this.txtTempFunc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempFunc2.WordWrap = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAgua);
            this.panel4.Controls.Add(this.btnAdicionarAgua);
            this.panel4.Location = new System.Drawing.Point(6, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 55);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTemperatura);
            this.panel5.Controls.Add(this.btnAlterarTemperatura);
            this.panel5.Location = new System.Drawing.Point(6, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 55);
            this.panel5.TabIndex = 6;
            // 
            // frmCaldeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 298);
            this.Controls.Add(this.gpFuncionario2);
            this.Controls.Add(this.gpFuncionario1);
            this.Controls.Add(this.gpCaldeira);
            this.Name = "frmCaldeira";
            this.Text = "Form1";
            this.gpCaldeira.ResumeLayout(false);
            this.gpFuncionario1.ResumeLayout(false);
            this.gpFuncionario2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCaldeira;
        private System.Windows.Forms.Label lblTemperaturaCaldeira;
        private System.Windows.Forms.Label lblNivelAguaCaldeira;
        private System.Windows.Forms.GroupBox gpFuncionario1;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.Button btnAdicionarAgua;
        private System.Windows.Forms.GroupBox gpFuncionario2;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnAlterarTemperatura;
        private System.Windows.Forms.TextBox txtTempCaldeira;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNivelAguaCaldeira;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNivelAguaFunc1;
        private System.Windows.Forms.Label lblTempFunc1;
        private System.Windows.Forms.Label lblNivelAguaFunc1;
        private System.Windows.Forms.TextBox txtTempFunc1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNivelAguaFunc2;
        private System.Windows.Forms.Label lblTempFunc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempFunc2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

