namespace RelogioDigital
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
            this.components = new System.ComponentModel.Container();
            this.LblRelógio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblRelógio
            // 
            this.LblRelógio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRelógio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblRelógio.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblRelógio.Location = new System.Drawing.Point(0, 0);
            this.LblRelógio.Name = "LblRelógio";
            this.LblRelógio.Size = new System.Drawing.Size(470, 201);
            this.LblRelógio.TabIndex = 0;
            this.LblRelógio.Text = "00:00:00";
            this.LblRelógio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 201);
            this.Controls.Add(this.LblRelógio);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Relógio Digital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblRelógio;
        private System.Windows.Forms.Timer timer1;
    }
}