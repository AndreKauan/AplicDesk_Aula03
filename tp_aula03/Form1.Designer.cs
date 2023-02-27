namespace tp_aula03
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lstTarefa = new System.Windows.Forms.ListBox();
            this.brnIncluir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarefa";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(86, 70);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(402, 32);
            this.txtTarefa.TabIndex = 2;
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(86, 23);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(402, 32);
            this.dtData.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dtData, "Digite a data da tarefa!");
            // 
            // lstTarefa
            // 
            this.lstTarefa.FormattingEnabled = true;
            this.lstTarefa.ItemHeight = 25;
            this.lstTarefa.Location = new System.Drawing.Point(19, 127);
            this.lstTarefa.Name = "lstTarefa";
            this.lstTarefa.Size = new System.Drawing.Size(604, 279);
            this.lstTarefa.TabIndex = 4;
            // 
            // brnIncluir
            // 
            this.brnIncluir.Location = new System.Drawing.Point(510, 45);
            this.brnIncluir.Name = "brnIncluir";
            this.brnIncluir.Size = new System.Drawing.Size(113, 33);
            this.brnIncluir.TabIndex = 5;
            this.brnIncluir.Text = "Incluir";
            this.brnIncluir.UseVisualStyleBackColor = true;
            this.brnIncluir.Click += new System.EventHandler(this.brnIncluir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(510, 426);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(113, 33);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(14, 434);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(55, 25);
            this.lblAviso.TabIndex = 8;
            this.lblAviso.Text = "Aviso";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 468);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.brnIncluir);
            this.Controls.Add(this.lstTarefa);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.ListBox lstTarefa;
        private System.Windows.Forms.Button brnIncluir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

