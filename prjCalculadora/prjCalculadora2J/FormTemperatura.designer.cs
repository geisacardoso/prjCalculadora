namespace prjCalculadora2J
{
    partial class FormTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemperatura));
            this.pnFrom = new System.Windows.Forms.Panel();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTo = new System.Windows.Forms.Panel();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnResposta = new System.Windows.Forms.Panel();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnFrom.SuspendLayout();
            this.pnTo.SuspendLayout();
            this.pnResposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFrom
            // 
            this.pnFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFrom.Controls.Add(this.rbFromK);
            this.pnFrom.Controls.Add(this.rbFromF);
            this.pnFrom.Controls.Add(this.rbFromC);
            this.pnFrom.Controls.Add(this.label1);
            this.pnFrom.Location = new System.Drawing.Point(12, 12);
            this.pnFrom.Name = "pnFrom";
            this.pnFrom.Size = new System.Drawing.Size(206, 213);
            this.pnFrom.TabIndex = 0;
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.Location = new System.Drawing.Point(32, 159);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(92, 22);
            this.rbFromK.TabIndex = 2;
            this.rbFromK.Text = "KELVIN";
            this.rbFromK.UseVisualStyleBackColor = true;
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.Location = new System.Drawing.Point(32, 104);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(137, 22);
            this.rbFromF.TabIndex = 2;
            this.rbFromF.Text = "FAHRENHEIT";
            this.rbFromF.UseVisualStyleBackColor = true;
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Checked = true;
            this.rbFromC.Location = new System.Drawing.Point(32, 51);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(102, 22);
            this.rbFromC.TabIndex = 1;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "CELSIUS";
            this.rbFromC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORIGEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTo
            // 
            this.pnTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTo.Controls.Add(this.rbToK);
            this.pnTo.Controls.Add(this.rbToF);
            this.pnTo.Controls.Add(this.rbToC);
            this.pnTo.Controls.Add(this.label2);
            this.pnTo.Location = new System.Drawing.Point(11, 231);
            this.pnTo.Name = "pnTo";
            this.pnTo.Size = new System.Drawing.Size(206, 213);
            this.pnTo.TabIndex = 0;
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Checked = true;
            this.rbToK.Location = new System.Drawing.Point(32, 159);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(92, 22);
            this.rbToK.TabIndex = 2;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "KELVIN";
            this.rbToK.UseVisualStyleBackColor = true;
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.Location = new System.Drawing.Point(32, 104);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(137, 22);
            this.rbToF.TabIndex = 2;
            this.rbToF.Text = "FAHRENHEIT";
            this.rbToF.UseVisualStyleBackColor = true;
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.Location = new System.Drawing.Point(32, 51);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(102, 22);
            this.rbToC.TabIndex = 1;
            this.rbToC.Text = "CELSIUS";
            this.rbToC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "DESTINO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnResposta
            // 
            this.pnResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnResposta.Controls.Add(this.lblTemperatura);
            this.pnResposta.Controls.Add(this.btnConverter);
            this.pnResposta.Controls.Add(this.txtTemperatura);
            this.pnResposta.Controls.Add(this.label4);
            this.pnResposta.Controls.Add(this.label3);
            this.pnResposta.Location = new System.Drawing.Point(224, 12);
            this.pnResposta.Name = "pnResposta";
            this.pnResposta.Size = new System.Drawing.Size(229, 432);
            this.pnResposta.TabIndex = 1;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.BackColor = System.Drawing.Color.White;
            this.lblTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemperatura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(17, 270);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(195, 151);
            this.lblTemperatura.TabIndex = 5;
            this.lblTemperatura.Text = "0,00";
            this.lblTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.White;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.Location = new System.Drawing.Point(17, 116);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(195, 130);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "CONVERTER TEMP";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(17, 76);
            this.txtTemperatura.MaxLength = 10;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(195, 26);
            this.txtTemperatura.TabIndex = 3;
            this.txtTemperatura.Text = "0";
            this.txtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemperatura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "DIGITE TEMPERATURA";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "TEMPERATURA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 454);
            this.Controls.Add(this.pnResposta);
            this.Controls.Add(this.pnTo);
            this.Controls.Add(this.pnFrom);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TERMOMETRO - CONVERSOR";
            this.pnFrom.ResumeLayout(false);
            this.pnFrom.PerformLayout();
            this.pnTo.ResumeLayout(false);
            this.pnTo.PerformLayout();
            this.pnResposta.ResumeLayout(false);
            this.pnResposta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFrom;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTo;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnResposta;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

