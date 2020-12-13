namespace Beadando_xgah8k
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.designedButton2 = new Beadando_xgah8k.DesignedButton();
            this.designedButton1 = new Beadando_xgah8k.DesignedButton();
            this.disabledTextBox2 = new Beadando_xgah8k.DisabledTextBox();
            this.disabledTextBox1 = new Beadando_xgah8k.DisabledTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(891, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(389, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Napi tranzakciók száma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(872, 550);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // designedButton2
            // 
            this.designedButton2.BackColor = System.Drawing.Color.LightSalmon;
            this.designedButton2.Location = new System.Drawing.Point(569, 584);
            this.designedButton2.Name = "designedButton2";
            this.designedButton2.Size = new System.Drawing.Size(100, 40);
            this.designedButton2.TabIndex = 10;
            this.designedButton2.Text = "Törlés";
            this.designedButton2.UseVisualStyleBackColor = false;
            this.designedButton2.Click += new System.EventHandler(this.designedButton2_Click);
            // 
            // designedButton1
            // 
            this.designedButton1.BackColor = System.Drawing.Color.LightSalmon;
            this.designedButton1.Location = new System.Drawing.Point(144, 584);
            this.designedButton1.Name = "designedButton1";
            this.designedButton1.Size = new System.Drawing.Size(100, 40);
            this.designedButton1.TabIndex = 9;
            this.designedButton1.Text = "Véletlen";
            this.designedButton1.UseVisualStyleBackColor = false;
            this.designedButton1.Click += new System.EventHandler(this.designedButton1_Click);
            // 
            // disabledTextBox2
            // 
            this.disabledTextBox2.BackColor = System.Drawing.Color.White;
            this.disabledTextBox2.Enabled = false;
            this.disabledTextBox2.Location = new System.Drawing.Point(463, 591);
            this.disabledTextBox2.Name = "disabledTextBox2";
            this.disabledTextBox2.Size = new System.Drawing.Size(100, 26);
            this.disabledTextBox2.TabIndex = 7;
            // 
            // disabledTextBox1
            // 
            this.disabledTextBox1.BackColor = System.Drawing.Color.White;
            this.disabledTextBox1.Enabled = false;
            this.disabledTextBox1.Location = new System.Drawing.Point(38, 591);
            this.disabledTextBox1.Name = "disabledTextBox1";
            this.disabledTextBox1.Size = new System.Drawing.Size(100, 26);
            this.disabledTextBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.designedButton2);
            this.Controls.Add(this.designedButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.disabledTextBox2);
            this.Controls.Add(this.disabledTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DisabledTextBox disabledTextBox1;
        private DisabledTextBox disabledTextBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DesignedButton designedButton2;
        private DesignedButton designedButton1;
    }
}

