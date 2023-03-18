namespace THA_W3_NEW
{
    partial class secondwindowform
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
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.truecheckbox2 = new System.Windows.Forms.CheckBox();
            this.agree = new System.Windows.Forms.CheckBox();
            this.magicbtn = new System.Windows.Forms.Button();
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundblue = new System.Windows.Forms.RadioButton();
            this.backgroundgreen = new System.Windows.Forms.RadioButton();
            this.backgroundred = new System.Windows.Forms.RadioButton();
            this.backgroundyellow = new System.Windows.Forms.RadioButton();
            this.backgroundorange = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bluetext = new System.Windows.Forms.RadioButton();
            this.greentext = new System.Windows.Forms.RadioButton();
            this.redtext = new System.Windows.Forms.RadioButton();
            this.backgroundpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(83, 34);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(41, 13);
            this.result.TabIndex = 1;
            this.result.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick Your Favourite Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pick Text Color";
            // 
            // truecheckbox2
            // 
            this.truecheckbox2.AutoSize = true;
            this.truecheckbox2.Location = new System.Drawing.Point(86, 366);
            this.truecheckbox2.Name = "truecheckbox2";
            this.truecheckbox2.Size = new System.Drawing.Size(197, 17);
            this.truecheckbox2.TabIndex = 7;
            this.truecheckbox2.Text = "All of the content I put above is true!";
            this.truecheckbox2.UseVisualStyleBackColor = true;
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(86, 343);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(187, 17);
            this.agree.TabIndex = 8;
            this.agree.Text = "I agree to the Terms of Agreement";
            this.agree.UseVisualStyleBackColor = true;
            // 
            // magicbtn
            // 
            this.magicbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicbtn.Location = new System.Drawing.Point(83, 389);
            this.magicbtn.Name = "magicbtn";
            this.magicbtn.Size = new System.Drawing.Size(72, 22);
            this.magicbtn.TabIndex = 9;
            this.magicbtn.Text = "MAGIC";
            this.magicbtn.UseVisualStyleBackColor = true;
            this.magicbtn.Click += new System.EventHandler(this.magicbtn_Click);
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.Controls.Add(this.panel2);
            this.backgroundpanel.Controls.Add(this.panel1);
            this.backgroundpanel.Location = new System.Drawing.Point(-4, -9);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(808, 460);
            this.backgroundpanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backgroundorange);
            this.panel1.Controls.Add(this.backgroundyellow);
            this.panel1.Controls.Add(this.backgroundblue);
            this.panel1.Controls.Add(this.backgroundgreen);
            this.panel1.Controls.Add(this.backgroundred);
            this.panel1.Location = new System.Drawing.Point(90, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 10;
            // 
            // backgroundblue
            // 
            this.backgroundblue.AutoSize = true;
            this.backgroundblue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundblue.Location = new System.Drawing.Point(13, 59);
            this.backgroundblue.Name = "backgroundblue";
            this.backgroundblue.Size = new System.Drawing.Size(52, 17);
            this.backgroundblue.TabIndex = 9;
            this.backgroundblue.TabStop = true;
            this.backgroundblue.Text = "BLUE";
            this.backgroundblue.UseVisualStyleBackColor = true;
            // 
            // backgroundgreen
            // 
            this.backgroundgreen.AutoSize = true;
            this.backgroundgreen.Location = new System.Drawing.Point(13, 36);
            this.backgroundgreen.Name = "backgroundgreen";
            this.backgroundgreen.Size = new System.Drawing.Size(63, 17);
            this.backgroundgreen.TabIndex = 9;
            this.backgroundgreen.TabStop = true;
            this.backgroundgreen.Text = "GREEN";
            this.backgroundgreen.UseVisualStyleBackColor = true;
            // 
            // backgroundred
            // 
            this.backgroundred.AutoSize = true;
            this.backgroundred.Location = new System.Drawing.Point(13, 13);
            this.backgroundred.Name = "backgroundred";
            this.backgroundred.Size = new System.Drawing.Size(48, 17);
            this.backgroundred.TabIndex = 9;
            this.backgroundred.TabStop = true;
            this.backgroundred.Text = "RED";
            this.backgroundred.UseVisualStyleBackColor = true;
            // 
            // backgroundyellow
            // 
            this.backgroundyellow.AutoSize = true;
            this.backgroundyellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundyellow.Location = new System.Drawing.Point(98, 13);
            this.backgroundyellow.Name = "backgroundyellow";
            this.backgroundyellow.Size = new System.Drawing.Size(69, 17);
            this.backgroundyellow.TabIndex = 10;
            this.backgroundyellow.TabStop = true;
            this.backgroundyellow.Text = "YELLOW";
            this.backgroundyellow.UseVisualStyleBackColor = true;
            // 
            // backgroundorange
            // 
            this.backgroundorange.AutoSize = true;
            this.backgroundorange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundorange.Location = new System.Drawing.Point(98, 36);
            this.backgroundorange.Name = "backgroundorange";
            this.backgroundorange.Size = new System.Drawing.Size(70, 17);
            this.backgroundorange.TabIndex = 11;
            this.backgroundorange.TabStop = true;
            this.backgroundorange.Text = "ORANGE";
            this.backgroundorange.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bluetext);
            this.panel2.Controls.Add(this.greentext);
            this.panel2.Controls.Add(this.redtext);
            this.panel2.Location = new System.Drawing.Point(90, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 12;
            // 
            // bluetext
            // 
            this.bluetext.AutoSize = true;
            this.bluetext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluetext.Location = new System.Drawing.Point(13, 59);
            this.bluetext.Name = "bluetext";
            this.bluetext.Size = new System.Drawing.Size(52, 17);
            this.bluetext.TabIndex = 9;
            this.bluetext.TabStop = true;
            this.bluetext.Text = "BLUE";
            this.bluetext.UseVisualStyleBackColor = true;
            // 
            // greentext
            // 
            this.greentext.AutoSize = true;
            this.greentext.Location = new System.Drawing.Point(13, 36);
            this.greentext.Name = "greentext";
            this.greentext.Size = new System.Drawing.Size(63, 17);
            this.greentext.TabIndex = 9;
            this.greentext.TabStop = true;
            this.greentext.Text = "GREEN";
            this.greentext.UseVisualStyleBackColor = true;
            // 
            // redtext
            // 
            this.redtext.AutoSize = true;
            this.redtext.Location = new System.Drawing.Point(13, 13);
            this.redtext.Name = "redtext";
            this.redtext.Size = new System.Drawing.Size(48, 17);
            this.redtext.TabIndex = 9;
            this.redtext.TabStop = true;
            this.redtext.Text = "RED";
            this.redtext.UseVisualStyleBackColor = true;
            // 
            // secondwindowform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.magicbtn);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.truecheckbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.backgroundpanel);
            this.Name = "secondwindowform";
            this.Text = "Second Window Form";
            this.backgroundpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox truecheckbox2;
        private System.Windows.Forms.CheckBox agree;
        private System.Windows.Forms.Button magicbtn;
        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton backgroundblue;
        private System.Windows.Forms.RadioButton backgroundgreen;
        private System.Windows.Forms.RadioButton backgroundred;
        private System.Windows.Forms.RadioButton backgroundorange;
        private System.Windows.Forms.RadioButton backgroundyellow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton bluetext;
        private System.Windows.Forms.RadioButton greentext;
        private System.Windows.Forms.RadioButton redtext;
    }
}