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
            this.lblPlayer2ChoiceValue = new System.Windows.Forms.Label();
            this.lblPlayer1ChoiceValue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
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
            // lblPlayer2ChoiceValue
            // 
            this.lblPlayer2ChoiceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2ChoiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2ChoiceValue.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2ChoiceValue.Location = new System.Drawing.Point(515, 203);
            this.lblPlayer2ChoiceValue.Name = "lblPlayer2ChoiceValue";
            this.lblPlayer2ChoiceValue.Size = new System.Drawing.Size(103, 74);
            this.lblPlayer2ChoiceValue.TabIndex = 2;
            this.lblPlayer2ChoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1ChoiceValue
            // 
            this.lblPlayer1ChoiceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1ChoiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1ChoiceValue.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer1ChoiceValue.Location = new System.Drawing.Point(285, 203);
            this.lblPlayer1ChoiceValue.Name = "lblPlayer1ChoiceValue";
            this.lblPlayer1ChoiceValue.Size = new System.Drawing.Size(103, 74);
            this.lblPlayer1ChoiceValue.TabIndex = 3;
            this.lblPlayer1ChoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBack.TabIndex = 5;
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
            // frmPlayersChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Project.Properties.Resources._2_Warriors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayer1ChoiceValue);
            this.Controls.Add(this.lblPlayer2ChoiceValue);
            this.Controls.Add(this.lblPlayer2Choice);
            this.Controls.Add(this.lblPlayer1Choice);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmPlayersChoices";
            this.Text = "Win Blade";
            this.Load += new System.EventHandler(this.frmPlayersChoices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1Choice;
        private System.Windows.Forms.Label lblPlayer2Choice;
        private System.Windows.Forms.Label lblPlayer2ChoiceValue;
        private System.Windows.Forms.Label lblPlayer1ChoiceValue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTimer;
    }
}