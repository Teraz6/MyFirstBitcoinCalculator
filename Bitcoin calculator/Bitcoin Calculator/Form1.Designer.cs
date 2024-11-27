namespace Bitcoin_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemuslabel = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyselector
            // 
            this.currencyselector.BackColor = System.Drawing.SystemColors.Window;
            this.currencyselector.Cursor = System.Windows.Forms.Cursors.Default;
            this.currencyselector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "EEK",
            "GBP"});
            this.currencyselector.Location = new System.Drawing.Point(368, 113);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(113, 21);
            this.currencyselector.TabIndex = 0;
            this.currencyselector.Text = "Vali valuuta";
            this.currencyselector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(368, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta kurss";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.AcceptsReturn = true;
            this.bitcoinamountinput.AcceptsTab = true;
            this.bitcoinamountinput.Location = new System.Drawing.Point(368, 78);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(113, 20);
            this.bitcoinamountinput.TabIndex = 2;
            this.bitcoinamountinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bitcoinamountinput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(353, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta Bitcoini arv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tulemuslabel
            // 
            this.tulemuslabel.AutoSize = true;
            this.tulemuslabel.BackColor = System.Drawing.Color.Transparent;
            this.tulemuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tulemuslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.tulemuslabel.Location = new System.Drawing.Point(365, 231);
            this.tulemuslabel.Name = "tulemuslabel";
            this.tulemuslabel.Size = new System.Drawing.Size(66, 17);
            this.tulemuslabel.TabIndex = 4;
            this.tulemuslabel.Text = "Tulemus:";
            this.tulemuslabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.BackColor = System.Drawing.Color.White;
            this.resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.resultlabel.Location = new System.Drawing.Point(280, 251);
            this.resultlabel.Multiline = true;
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(293, 120);
            this.resultlabel.TabIndex = 5;
            this.resultlabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultlabel.TextChanged += new System.EventHandler(this.resultlabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.tulemuslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyselector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BitcoinCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemuslabel;
        private System.Windows.Forms.TextBox resultlabel;
    }
}

