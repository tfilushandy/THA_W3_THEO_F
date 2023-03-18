namespace THA_W3_NEW
{
    partial class mainwindowform
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
            this.openformbtn = new System.Windows.Forms.Button();
            this.lblnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkboxtrue = new System.Windows.Forms.CheckBox();
            this.namatext = new System.Windows.Forms.TextBox();
            this.artistext = new System.Windows.Forms.TextBox();
            this.panelform1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openformbtn
            // 
            this.openformbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openformbtn.Location = new System.Drawing.Point(619, 402);
            this.openformbtn.Name = "openformbtn";
            this.openformbtn.Size = new System.Drawing.Size(169, 36);
            this.openformbtn.TabIndex = 0;
            this.openformbtn.Text = "Open Next Form";
            this.openformbtn.UseVisualStyleBackColor = true;
            this.openformbtn.Click += new System.EventHandler(this.openformbtn_Click);
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(130, 92);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(44, 13);
            this.lblnama.TabIndex = 1;
            this.lblnama.Text = "NAMA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Fav Artist :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkboxtrue
            // 
            this.checkboxtrue.AutoSize = true;
            this.checkboxtrue.Location = new System.Drawing.Point(131, 144);
            this.checkboxtrue.Name = "checkboxtrue";
            this.checkboxtrue.Size = new System.Drawing.Size(197, 17);
            this.checkboxtrue.TabIndex = 4;
            this.checkboxtrue.Text = "All of the content I put above is true!";
            this.checkboxtrue.UseVisualStyleBackColor = true;
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(201, 89);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(129, 20);
            this.namatext.TabIndex = 5;
            // 
            // artistext
            // 
            this.artistext.Location = new System.Drawing.Point(201, 115);
            this.artistext.Name = "artistext";
            this.artistext.Size = new System.Drawing.Size(129, 20);
            this.artistext.TabIndex = 6;
            // 
            // panelform1
            // 
            this.panelform1.Location = new System.Drawing.Point(-5, -4);
            this.panelform1.Name = "panelform1";
            this.panelform1.Size = new System.Drawing.Size(811, 460);
            this.panelform1.TabIndex = 7;
            // 
            // mainwindowform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.artistext);
            this.Controls.Add(this.namatext);
            this.Controls.Add(this.checkboxtrue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.openformbtn);
            this.Controls.Add(this.panelform1);
            this.Name = "mainwindowform";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openformbtn;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkboxtrue;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.TextBox artistext;
        private System.Windows.Forms.Panel panelform1;
    }
}

