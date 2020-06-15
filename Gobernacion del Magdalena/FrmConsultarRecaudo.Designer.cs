namespace Gobernacion_del_Magdalena
{
    partial class FrmConsultarRecaudo
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
            this.DgvRecaudo = new System.Windows.Forms.DataGridView();
            this.CmbMes = new System.Windows.Forms.ComboBox();
            this.CmbVigencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.CmbEstampilla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRecaudo
            // 
            this.DgvRecaudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecaudo.Location = new System.Drawing.Point(114, 123);
            this.DgvRecaudo.Name = "DgvRecaudo";
            this.DgvRecaudo.Size = new System.Drawing.Size(532, 150);
            this.DgvRecaudo.TabIndex = 0;
            // 
            // CmbMes
            // 
            this.CmbMes.FormattingEnabled = true;
            this.CmbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CmbMes.Location = new System.Drawing.Point(110, 58);
            this.CmbMes.Name = "CmbMes";
            this.CmbMes.Size = new System.Drawing.Size(121, 21);
            this.CmbMes.TabIndex = 1;
            // 
            // CmbVigencia
            // 
            this.CmbVigencia.FormattingEnabled = true;
            this.CmbVigencia.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.CmbVigencia.Location = new System.Drawing.Point(272, 59);
            this.CmbVigencia.Name = "CmbVigencia";
            this.CmbVigencia.Size = new System.Drawing.Size(121, 21);
            this.CmbVigencia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "VIGENCIA DEL RECAUDO";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(672, 29);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(95, 23);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(202, 301);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total recaudado";
            // 
            // BtnTotal
            // 
            this.BtnTotal.Location = new System.Drawing.Point(311, 298);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(95, 23);
            this.BtnTotal.TabIndex = 8;
            this.BtnTotal.Text = "TOTAL";
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // CmbEstampilla
            // 
            this.CmbEstampilla.FormattingEnabled = true;
            this.CmbEstampilla.Items.AddRange(new object[] {
            "Adulto Mayor"});
            this.CmbEstampilla.Location = new System.Drawing.Point(434, 59);
            this.CmbEstampilla.Name = "CmbEstampilla";
            this.CmbEstampilla.Size = new System.Drawing.Size(121, 21);
            this.CmbEstampilla.TabIndex = 9;
            this.CmbEstampilla.SelectedIndexChanged += new System.EventHandler(this.CmbEstampilla_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TIPO ESTAMPILLA";
            // 
            // FrmConsultarRecaudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbEstampilla);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbVigencia);
            this.Controls.Add(this.CmbMes);
            this.Controls.Add(this.DgvRecaudo);
            this.Name = "FrmConsultarRecaudo";
            this.Text = "FrmConsultarRecaudo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRecaudo;
        private System.Windows.Forms.ComboBox CmbMes;
        private System.Windows.Forms.ComboBox CmbVigencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.ComboBox CmbEstampilla;
        private System.Windows.Forms.Label label4;
    }
}