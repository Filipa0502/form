namespace Exercicio_4
{
    partial class Form2
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
            this.lbAno = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbAno1 = new System.Windows.Forms.Label();
            this.lbCurso1 = new System.Windows.Forms.Label();
            this.lbNome1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(41, 157);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(38, 18);
            this.lbAno.TabIndex = 5;
            this.lbAno.Text = "Ano:";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurso.Location = new System.Drawing.Point(41, 107);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(53, 18);
            this.lbCurso.TabIndex = 4;
            this.lbCurso.Text = "Curso:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(41, 56);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 18);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome:";
            // 
            // lbAno1
            // 
            this.lbAno1.AutoSize = true;
            this.lbAno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno1.Location = new System.Drawing.Point(118, 157);
            this.lbAno1.Name = "lbAno1";
            this.lbAno1.Size = new System.Drawing.Size(0, 18);
            this.lbAno1.TabIndex = 8;
            // 
            // lbCurso1
            // 
            this.lbCurso1.AutoSize = true;
            this.lbCurso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurso1.Location = new System.Drawing.Point(118, 107);
            this.lbCurso1.Name = "lbCurso1";
            this.lbCurso1.Size = new System.Drawing.Size(0, 18);
            this.lbCurso1.TabIndex = 7;
            // 
            // lbNome1
            // 
            this.lbNome1.AutoSize = true;
            this.lbNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome1.Location = new System.Drawing.Point(118, 56);
            this.lbNome1.Name = "lbNome1";
            this.lbNome1.Size = new System.Drawing.Size(0, 18);
            this.lbNome1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 302);
            this.Controls.Add(this.lbAno1);
            this.Controls.Add(this.lbCurso1);
            this.Controls.Add(this.lbNome1);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbNome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbAno1;
        private System.Windows.Forms.Label lbCurso1;
        private System.Windows.Forms.Label lbNome1;
    }
}