namespace Server
{
    partial class Server
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(72, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 253);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 27);
            this.textBox2.TabIndex = 7;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(577, 60);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(151, 66);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(577, 361);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(577, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 27);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Send);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button Connect;
        private Button Send;
        private TextBox textBox3;
        private TextBox textBox1;
    }
}