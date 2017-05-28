namespace SportsBets
{
    partial class StartPage
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
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAnimacija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Location = new System.Drawing.Point(11, 306);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(137, 23);
            this.btnNewTicket.TabIndex = 1;
            this.btnNewTicket.Text = "Креирање на нов тикет";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(290, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Излез";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAnimacija
            // 
            this.lblAnimacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimacija.ForeColor = System.Drawing.Color.Red;
            this.lblAnimacija.Location = new System.Drawing.Point(112, 73);
            this.lblAnimacija.Name = "lblAnimacija";
            this.lblAnimacija.Size = new System.Drawing.Size(220, 199);
            this.lblAnimacija.TabIndex = 4;
            this.lblAnimacija.Text = "Играјте\r\n и \r\nдобијте";
            this.lblAnimacija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добредојдовте во најдобрата кладилница во градот";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenTicket
            // 
            this.btnOpenTicket.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpenTicket.Location = new System.Drawing.Point(154, 306);
            this.btnOpenTicket.Name = "btnOpenTicket";
            this.btnOpenTicket.Size = new System.Drawing.Size(130, 23);
            this.btnOpenTicket.TabIndex = 5;
            this.btnOpenTicket.Text = "Преглед на тикети";
            this.btnOpenTicket.UseVisualStyleBackColor = true;
            this.btnOpenTicket.Click += new System.EventHandler(this.btnOpenTicket_Click);
            // 
            // StartPage
            // 
            this.AcceptButton = this.btnNewTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(440, 341);
            this.Controls.Add(this.btnOpenTicket);
            this.Controls.Add(this.lblAnimacija);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.label1);
            this.Name = "StartPage";
            this.Text = "Почетна";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StartPage_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAnimacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenTicket;

    }
}