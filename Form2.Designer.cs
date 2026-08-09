namespace Tic_Tac_Toe_Project
{
    partial class frmChooseBlade
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which blade do you want to fight with?";
            // 
            // btnX
            // 
            this.btnX.AutoSize = true;
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.X_Blade_Shape;
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnX.FlatAppearance.BorderSize = 2;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(612, 448);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(146, 124);
            this.btnX.TabIndex = 1;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnO
            // 
            this.btnO.AutoSize = true;
            this.btnO.BackColor = System.Drawing.Color.Transparent;
            this.btnO.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.O_Blade_Shape;
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnO.FlatAppearance.BorderSize = 2;
            this.btnO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btnO.ForeColor = System.Drawing.Color.White;
            this.btnO.Location = new System.Drawing.Point(153, 448);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(146, 124);
            this.btnO.TabIndex = 2;
            this.btnO.Tag = "1";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmChooseBlade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources._2_Warriors_Side_By_Side;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmChooseBlade";
            this.Text = "Win Blade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnBack;
    }
}