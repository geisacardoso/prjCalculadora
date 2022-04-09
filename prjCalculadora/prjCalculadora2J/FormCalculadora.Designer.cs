namespace prjCalculadora2J
{
    partial class FormCalculadora
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblVisor = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoProgramador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoTemperatura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnInverterSinal = new System.Windows.Forms.Button();
            this.btnPontoDecimal = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnCosseno = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.pnSuperior.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.lblVisor);
            this.pnSuperior.Controls.Add(this.menu);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(659, 119);
            this.pnSuperior.TabIndex = 0;
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVisor.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(0, 24);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(659, 95);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(659, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mnArquivo
            // 
            this.mnArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivoProgramador,
            this.mnArquivoTemperatura,
            this.mnArquivoSair});
            this.mnArquivo.ForeColor = System.Drawing.Color.Black;
            this.mnArquivo.Name = "mnArquivo";
            this.mnArquivo.Size = new System.Drawing.Size(70, 20);
            this.mnArquivo.Text = "ARQUIVO";
            // 
            // mnArquivoProgramador
            // 
            this.mnArquivoProgramador.Name = "mnArquivoProgramador";
            this.mnArquivoProgramador.Size = new System.Drawing.Size(163, 22);
            this.mnArquivoProgramador.Text = "PROGRAMADOR";
            this.mnArquivoProgramador.Click += new System.EventHandler(this.mnArquivoProgramador_Click);
            // 
            // mnArquivoTemperatura
            // 
            this.mnArquivoTemperatura.Name = "mnArquivoTemperatura";
            this.mnArquivoTemperatura.Size = new System.Drawing.Size(163, 22);
            this.mnArquivoTemperatura.Text = "TEMPERATURA";
            this.mnArquivoTemperatura.Click += new System.EventHandler(this.mnArquivoTemperatura_Click);
            // 
            // mnArquivoSair
            // 
            this.mnArquivoSair.Name = "mnArquivoSair";
            this.mnArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnArquivoSair.Size = new System.Drawing.Size(163, 22);
            this.mnArquivoSair.Text = "SAIR";
            this.mnArquivoSair.Click += new System.EventHandler(this.mnArquivoSair_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkCyan;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(5, 223);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(108, 92);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkCyan;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(119, 223);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(108, 92);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkCyan;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(233, 223);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(108, 92);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkCyan;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(5, 321);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(108, 92);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkCyan;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(119, 321);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(108, 92);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkCyan;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(233, 321);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(108, 92);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkCyan;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(5, 419);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 92);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkCyan;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(119, 419);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 92);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkCyan;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(233, 419);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(108, 92);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkCyan;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(119, 517);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(108, 92);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnInverterSinal
            // 
            this.btnInverterSinal.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInverterSinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverterSinal.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverterSinal.Location = new System.Drawing.Point(5, 517);
            this.btnInverterSinal.Name = "btnInverterSinal";
            this.btnInverterSinal.Size = new System.Drawing.Size(108, 92);
            this.btnInverterSinal.TabIndex = 21;
            this.btnInverterSinal.Text = "+/-";
            this.btnInverterSinal.UseVisualStyleBackColor = false;
            this.btnInverterSinal.Click += new System.EventHandler(this.btnInverterSinal_Click);
            // 
            // btnPontoDecimal
            // 
            this.btnPontoDecimal.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPontoDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPontoDecimal.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontoDecimal.Location = new System.Drawing.Point(233, 517);
            this.btnPontoDecimal.Name = "btnPontoDecimal";
            this.btnPontoDecimal.Size = new System.Drawing.Size(108, 92);
            this.btnPontoDecimal.TabIndex = 23;
            this.btnPontoDecimal.Text = ",";
            this.btnPontoDecimal.UseVisualStyleBackColor = false;
            this.btnPontoDecimal.Click += new System.EventHandler(this.btnPontoDecimal_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DarkCyan;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(5, 125);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(108, 92);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(119, 125);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(108, 92);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(233, 125);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(108, 92);
            this.btnBackSpace.TabIndex = 3;
            this.btnBackSpace.Text = "BK";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(221)))), ((int)(((byte)(189)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(347, 517);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 92);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(347, 223);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(108, 92);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(347, 321);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(108, 92);
            this.btnSubtrair.TabIndex = 14;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(347, 419);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(108, 92);
            this.btnSomar.TabIndex = 19;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(347, 125);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(108, 92);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentagem.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.Location = new System.Drawing.Point(461, 517);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(190, 92);
            this.btnPorcentagem.TabIndex = 25;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSeno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeno.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(461, 223);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(190, 92);
            this.btnSeno.TabIndex = 10;
            this.btnSeno.Text = "SEN";
            this.btnSeno.UseVisualStyleBackColor = false;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(461, 125);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(190, 92);
            this.btnRaiz.TabIndex = 5;
            this.btnRaiz.Text = "RAIZ";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnCosseno
            // 
            this.btnCosseno.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCosseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosseno.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosseno.Location = new System.Drawing.Point(461, 321);
            this.btnCosseno.Name = "btnCosseno";
            this.btnCosseno.Size = new System.Drawing.Size(190, 92);
            this.btnCosseno.TabIndex = 15;
            this.btnCosseno.Text = "COS";
            this.btnCosseno.UseVisualStyleBackColor = false;
            this.btnCosseno.Click += new System.EventHandler(this.btnCosseno_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTangente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTangente.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangente.Location = new System.Drawing.Point(461, 419);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(190, 92);
            this.btnTangente.TabIndex = 20;
            this.btnTangente.Text = "TAN";
            this.btnTangente.UseVisualStyleBackColor = false;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(659, 616);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnCosseno);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnInverterSinal);
            this.Controls.Add(this.btnPontoDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormCalculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnInverterSinal;
        private System.Windows.Forms.Button btnPontoDecimal;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnCosseno;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoProgramador;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoTemperatura;
    }
}

