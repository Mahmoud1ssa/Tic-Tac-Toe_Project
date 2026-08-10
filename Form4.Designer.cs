namespace Tic_Tac_Toe_Project
{
    partial class frmGame
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
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTurnValue = new System.Windows.Forms.Label();
            this.lblWinnerValue = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pnlBladeBoxes = new System.Windows.Forms.Panel();
            this.btnBlade2 = new System.Windows.Forms.Button();
            this.btnBlade3 = new System.Windows.Forms.Button();
            this.btnBlade4 = new System.Windows.Forms.Button();
            this.btnBlade7 = new System.Windows.Forms.Button();
            this.btnBlade9 = new System.Windows.Forms.Button();
            this.btnBlade6 = new System.Windows.Forms.Button();
            this.btnBlade8 = new System.Windows.Forms.Button();
            this.btnBlade5 = new System.Windows.Forms.Button();
            this.btnBlade1 = new System.Windows.Forms.Button();
            this.pnlBladeBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadLine.Font = new System.Drawing.Font("Permanent Marker", 28.2F);
            this.lblHeadLine.ForeColor = System.Drawing.Color.White;
            this.lblHeadLine.Location = new System.Drawing.Point(228, 9);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(439, 67);
            this.lblHeadLine.TabIndex = 15;
            this.lblHeadLine.Text = "Win Blade Battle";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Permanent Marker", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lblTurn.Location = new System.Drawing.Point(233, 411);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(98, 40);
            this.lblTurn.TabIndex = 16;
            this.lblTurn.Text = "Turn :";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Permanent Marker", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblWinner.Location = new System.Drawing.Point(233, 460);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(133, 40);
            this.lblWinner.TabIndex = 17;
            this.lblWinner.Text = "Winner :";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderSize = 3;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(375, 511);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(160, 53);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTurnValue
            // 
            this.lblTurnValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnValue.Font = new System.Drawing.Font("Permanent Marker", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnValue.ForeColor = System.Drawing.Color.Lime;
            this.lblTurnValue.Location = new System.Drawing.Point(368, 411);
            this.lblTurnValue.Name = "lblTurnValue";
            this.lblTurnValue.Size = new System.Drawing.Size(230, 40);
            this.lblTurnValue.TabIndex = 19;
            // 
            // lblWinnerValue
            // 
            this.lblWinnerValue.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerValue.Font = new System.Drawing.Font("Permanent Marker", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerValue.ForeColor = System.Drawing.Color.Lime;
            this.lblWinnerValue.Location = new System.Drawing.Point(368, 460);
            this.lblWinnerValue.Name = "lblWinnerValue";
            this.lblWinnerValue.Size = new System.Drawing.Size(230, 40);
            this.lblWinnerValue.TabIndex = 20;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.AutoSize = true;
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.BorderSize = 2;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Red;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(124, 39);
            this.btnMainMenu.TabIndex = 21;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click_1);
            // 
            // pnlBladeBoxes
            // 
            this.pnlBladeBoxes.BackColor = System.Drawing.Color.Transparent;
            this.pnlBladeBoxes.Controls.Add(this.btnBlade2);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade3);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade4);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade7);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade9);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade6);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade8);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade5);
            this.pnlBladeBoxes.Controls.Add(this.btnBlade1);
            this.pnlBladeBoxes.Location = new System.Drawing.Point(272, 113);
            this.pnlBladeBoxes.Name = "pnlBladeBoxes";
            this.pnlBladeBoxes.Size = new System.Drawing.Size(337, 295);
            this.pnlBladeBoxes.TabIndex = 22;
            // 
            // btnBlade2
            // 
            this.btnBlade2.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade2.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade2.FlatAppearance.BorderSize = 2;
            this.btnBlade2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade2.Location = new System.Drawing.Point(27, 106);
            this.btnBlade2.Name = "btnBlade2";
            this.btnBlade2.Size = new System.Drawing.Size(90, 83);
            this.btnBlade2.TabIndex = 23;
            this.btnBlade2.Tag = "0";
            this.btnBlade2.UseVisualStyleBackColor = false;
            this.btnBlade2.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade3
            // 
            this.btnBlade3.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade3.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade3.FlatAppearance.BorderSize = 2;
            this.btnBlade3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade3.Location = new System.Drawing.Point(27, 195);
            this.btnBlade3.Name = "btnBlade3";
            this.btnBlade3.Size = new System.Drawing.Size(90, 83);
            this.btnBlade3.TabIndex = 22;
            this.btnBlade3.Tag = "0";
            this.btnBlade3.UseVisualStyleBackColor = false;
            this.btnBlade3.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade4
            // 
            this.btnBlade4.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade4.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade4.FlatAppearance.BorderSize = 2;
            this.btnBlade4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade4.Location = new System.Drawing.Point(123, 17);
            this.btnBlade4.Name = "btnBlade4";
            this.btnBlade4.Size = new System.Drawing.Size(90, 83);
            this.btnBlade4.TabIndex = 21;
            this.btnBlade4.Tag = "0";
            this.btnBlade4.UseVisualStyleBackColor = false;
            this.btnBlade4.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade7
            // 
            this.btnBlade7.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade7.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade7.FlatAppearance.BorderSize = 2;
            this.btnBlade7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade7.Location = new System.Drawing.Point(219, 17);
            this.btnBlade7.Name = "btnBlade7";
            this.btnBlade7.Size = new System.Drawing.Size(90, 83);
            this.btnBlade7.TabIndex = 20;
            this.btnBlade7.Tag = "0";
            this.btnBlade7.UseVisualStyleBackColor = false;
            this.btnBlade7.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade9
            // 
            this.btnBlade9.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade9.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade9.FlatAppearance.BorderSize = 2;
            this.btnBlade9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade9.Location = new System.Drawing.Point(219, 195);
            this.btnBlade9.Name = "btnBlade9";
            this.btnBlade9.Size = new System.Drawing.Size(90, 83);
            this.btnBlade9.TabIndex = 19;
            this.btnBlade9.Tag = "0";
            this.btnBlade9.UseVisualStyleBackColor = false;
            this.btnBlade9.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade6
            // 
            this.btnBlade6.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade6.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade6.FlatAppearance.BorderSize = 2;
            this.btnBlade6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade6.Location = new System.Drawing.Point(123, 195);
            this.btnBlade6.Name = "btnBlade6";
            this.btnBlade6.Size = new System.Drawing.Size(90, 83);
            this.btnBlade6.TabIndex = 18;
            this.btnBlade6.Tag = "0";
            this.btnBlade6.UseVisualStyleBackColor = false;
            this.btnBlade6.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade8
            // 
            this.btnBlade8.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade8.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade8.FlatAppearance.BorderSize = 2;
            this.btnBlade8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade8.Location = new System.Drawing.Point(219, 106);
            this.btnBlade8.Name = "btnBlade8";
            this.btnBlade8.Size = new System.Drawing.Size(90, 83);
            this.btnBlade8.TabIndex = 17;
            this.btnBlade8.Tag = "0";
            this.btnBlade8.UseVisualStyleBackColor = false;
            this.btnBlade8.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade5
            // 
            this.btnBlade5.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade5.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade5.FlatAppearance.BorderSize = 2;
            this.btnBlade5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade5.Location = new System.Drawing.Point(123, 106);
            this.btnBlade5.Name = "btnBlade5";
            this.btnBlade5.Size = new System.Drawing.Size(90, 83);
            this.btnBlade5.TabIndex = 16;
            this.btnBlade5.Tag = "0";
            this.btnBlade5.UseVisualStyleBackColor = false;
            this.btnBlade5.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnBlade1
            // 
            this.btnBlade1.BackColor = System.Drawing.Color.Transparent;
            this.btnBlade1.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources.Question_Mark_3D_Shape;
            this.btnBlade1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlade1.FlatAppearance.BorderSize = 2;
            this.btnBlade1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBlade1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade1.Location = new System.Drawing.Point(27, 17);
            this.btnBlade1.Name = "btnBlade1";
            this.btnBlade1.Size = new System.Drawing.Size(90, 83);
            this.btnBlade1.TabIndex = 15;
            this.btnBlade1.Tag = "0";
            this.btnBlade1.UseVisualStyleBackColor = false;
            this.btnBlade1.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources._2_Warriors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.pnlBladeBoxes);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblWinnerValue);
            this.Controls.Add(this.lblTurnValue);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblHeadLine);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Blade";
            this.pnlBladeBoxes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTurnValue;
        private System.Windows.Forms.Label lblWinnerValue;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel pnlBladeBoxes;
        private System.Windows.Forms.Button btnBlade2;
        private System.Windows.Forms.Button btnBlade3;
        private System.Windows.Forms.Button btnBlade4;
        private System.Windows.Forms.Button btnBlade7;
        private System.Windows.Forms.Button btnBlade9;
        private System.Windows.Forms.Button btnBlade6;
        private System.Windows.Forms.Button btnBlade8;
        private System.Windows.Forms.Button btnBlade5;
        private System.Windows.Forms.Button btnBlade1;
    }
}