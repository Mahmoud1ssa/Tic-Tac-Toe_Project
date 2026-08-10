namespace Tic_Tac_Toe_Project
{
    partial class frmPlayersChoices
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
            this.lblPlayer1Choice = new System.Windows.Forms.Label();
            this.lblPlayer2Choice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.picPlayer1Choice = new System.Windows.Forms.PictureBox();
            this.picPlayer2Choice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1Choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2Choice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1Choice
            // 
            this.lblPlayer1Choice.AutoSize = true;
            this.lblPlayer1Choice.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Choice.Font = new System.Drawing.Font("Permanent Marker", 18F);
            this.lblPlayer1Choice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer1Choice.Location = new System.Drawing.Point(265, 144);
            this.lblPlayer1Choice.Name = "lblPlayer1Choice";
            this.lblPlayer1Choice.Size = new System.Drawing.Size(147, 43);
            this.lblPlayer1Choice.TabIndex = 0;
            this.lblPlayer1Choice.Text = "Player 1 ";
            // 
            // lblPlayer2Choice
            // 
            this.lblPlayer2Choice.AutoSize = true;
            this.lblPlayer2Choice.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Choice.Font = new System.Drawing.Font("Permanent Marker", 18F);
            this.lblPlayer2Choice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer2Choice.Location = new System.Drawing.Point(494, 144);
            this.lblPlayer2Choice.Name = "lblPlayer2Choice";
            this.lblPlayer2Choice.Size = new System.Drawing.Size(157, 43);
            this.lblPlayer2Choice.TabIndex = 1;
            this.lblPlayer2Choice.Text = "Player 2 ";
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
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblTimer.Location = new System.Drawing.Point(396, 373);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(118, 113);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPlayer1Choice
            // 
            this.picPlayer1Choice.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer1Choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer1Choice.Location = new System.Drawing.Point(290, 215);
            this.picPlayer1Choice.Name = "picPlayer1Choice";
            this.picPlayer1Choice.Size = new System.Drawing.Size(90, 83);
            this.picPlayer1Choice.TabIndex = 7;
            this.picPlayer1Choice.TabStop = false;
            // 
            // picPlayer2Choice
            // 
            this.picPlayer2Choice.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer2Choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer2Choice.Location = new System.Drawing.Point(520, 215);
            this.picPlayer2Choice.Name = "picPlayer2Choice";
            this.picPlayer2Choice.Size = new System.Drawing.Size(90, 83);
            this.picPlayer2Choice.TabIndex = 8;
            this.picPlayer2Choice.TabStop = false;
            // 
            // frmPlayersChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources._2_Warriors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.picPlayer2Choice);
            this.Controls.Add(this.picPlayer1Choice);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayer2Choice);
            this.Controls.Add(this.lblPlayer1Choice);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmPlayersChoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Blade";
            this.Shown += new System.EventHandler(this.frmPlayersChoices_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1Choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2Choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1Choice;
        private System.Windows.Forms.Label lblPlayer2Choice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picPlayer1Choice;
        private System.Windows.Forms.PictureBox picPlayer2Choice;
    }
}