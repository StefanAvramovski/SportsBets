namespace SportsBets
{
    partial class TicketsView
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
            this.lstMatch = new System.Windows.Forms.ListBox();
            this.lblVremeNaTiket = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.btnSaveTicket = new System.Windows.Forms.Button();
            this.btnOpenTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Преглед на тикет одигран на:";
            // 
            // lstMatch
            // 
            this.lstMatch.FormattingEnabled = true;
            this.lstMatch.Location = new System.Drawing.Point(12, 54);
            this.lstMatch.Name = "lstMatch";
            this.lstMatch.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstMatch.Size = new System.Drawing.Size(449, 342);
            this.lstMatch.TabIndex = 7;
            // 
            // lblVremeNaTiket
            // 
            this.lblVremeNaTiket.AutoSize = true;
            this.lblVremeNaTiket.Location = new System.Drawing.Point(13, 21);
            this.lblVremeNaTiket.Name = "lblVremeNaTiket";
            this.lblVremeNaTiket.Size = new System.Drawing.Size(35, 13);
            this.lblVremeNaTiket.TabIndex = 8;
            this.lblVremeNaTiket.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Натпревар";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(12, 401);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(35, 13);
            this.lblReward.TabIndex = 33;
            this.lblReward.Text = "label2";
            // 
            // btnSaveTicket
            // 
            this.btnSaveTicket.Location = new System.Drawing.Point(334, 400);
            this.btnSaveTicket.Name = "btnSaveTicket";
            this.btnSaveTicket.Size = new System.Drawing.Size(127, 22);
            this.btnSaveTicket.TabIndex = 34;
            this.btnSaveTicket.Text = "Зачувај тикет";
            this.btnSaveTicket.UseVisualStyleBackColor = true;
            this.btnSaveTicket.Click += new System.EventHandler(this.btnSaveTicket_Click);
            // 
            // btnOpenTicket
            // 
            this.btnOpenTicket.Location = new System.Drawing.Point(201, 400);
            this.btnOpenTicket.Name = "btnOpenTicket";
            this.btnOpenTicket.Size = new System.Drawing.Size(127, 21);
            this.btnOpenTicket.TabIndex = 35;
            this.btnOpenTicket.Text = "Отвори постоечки";
            this.btnOpenTicket.UseVisualStyleBackColor = true;
            this.btnOpenTicket.Click += new System.EventHandler(this.btnOpenTicket_Click);
            // 
            // TicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 427);
            this.Controls.Add(this.btnOpenTicket);
            this.Controls.Add(this.btnSaveTicket);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVremeNaTiket);
            this.Controls.Add(this.lstMatch);
            this.Controls.Add(this.label1);
            this.Name = "TicketsView";
            this.Text = "Преглед на тикет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMatch;
        private System.Windows.Forms.Label lblVremeNaTiket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Button btnSaveTicket;
        private System.Windows.Forms.Button btnOpenTicket;
    }
}