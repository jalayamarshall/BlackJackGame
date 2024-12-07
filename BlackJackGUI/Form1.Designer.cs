namespace BlackJackGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDealer = new GroupBox();
            lstDealersHand = new ListBox();
            grpPlayer = new GroupBox();
            btnHit = new Button();
            btnStay = new Button();
            lstPlayersHand = new ListBox();
            btnRules = new Button();
            btnExit = new Button();
            grpDealer.SuspendLayout();
            grpPlayer.SuspendLayout();
            SuspendLayout();
            // 
            // grpDealer
            // 
            grpDealer.Controls.Add(lstDealersHand);
            grpDealer.Location = new Point(99, 149);
            grpDealer.Name = "grpDealer";
            grpDealer.Size = new Size(250, 262);
            grpDealer.TabIndex = 0;
            grpDealer.TabStop = false;
            grpDealer.Text = "Dealer";
            // 
            // lstDealersHand
            // 
            lstDealersHand.AccessibleName = "Dealer's Hand";
            lstDealersHand.FormattingEnabled = true;
            lstDealersHand.Location = new Point(22, 72);
            lstDealersHand.Name = "lstDealersHand";
            lstDealersHand.Size = new Size(150, 104);
            lstDealersHand.TabIndex = 0;
            // 
            // grpPlayer
            // 
            grpPlayer.Controls.Add(btnHit);
            grpPlayer.Controls.Add(btnStay);
            grpPlayer.Controls.Add(lstPlayersHand);
            grpPlayer.Location = new Point(491, 149);
            grpPlayer.Name = "grpPlayer";
            grpPlayer.Size = new Size(250, 262);
            grpPlayer.TabIndex = 1;
            grpPlayer.TabStop = false;
            grpPlayer.Text = "Player";
            // 
            // btnHit
            // 
            btnHit.Location = new Point(138, 204);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(94, 29);
            btnHit.TabIndex = 2;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            // 
            // btnStay
            // 
            btnStay.Location = new Point(27, 204);
            btnStay.Name = "btnStay";
            btnStay.Size = new Size(94, 29);
            btnStay.TabIndex = 1;
            btnStay.Text = "Stay";
            btnStay.UseVisualStyleBackColor = true;
            // 
            // lstPlayersHand
            // 
            lstPlayersHand.AccessibleName = "Player's Hand";
            lstPlayersHand.FormattingEnabled = true;
            lstPlayersHand.Location = new Point(28, 60);
            lstPlayersHand.Name = "lstPlayersHand";
            lstPlayersHand.Size = new Size(150, 104);
            lstPlayersHand.TabIndex = 0;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(30, 23);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(94, 29);
            btnRules.TabIndex = 2;
            btnRules.Text = "Rules";
            btnRules.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(675, 23);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnRules);
            Controls.Add(grpPlayer);
            Controls.Add(grpDealer);
            Name = "Form1";
            Text = "Form1";
            grpDealer.ResumeLayout(false);
            grpPlayer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDealer;
        private GroupBox grpPlayer;
        private ListBox lstDealersHand;
        private ListBox lstPlayersHand;
        private Button btnRules;
        private Button btnExit;
        private Button btnHit;
        private Button btnStay;
    }
}
