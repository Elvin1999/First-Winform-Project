namespace WindowsFormsApp1
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnametextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.femaleradioButton2 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(426, 196);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(61, 25);
            this.button.TabIndex = 0;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            this.button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(213, 91);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(101, 20);
            this.nametextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // surnametextBox
            // 
            this.surnametextBox.Location = new System.Drawing.Point(213, 130);
            this.surnametextBox.Name = "surnametextBox";
            this.surnametextBox.Size = new System.Drawing.Size(101, 20);
            this.surnametextBox.TabIndex = 5;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(213, 169);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(101, 20);
            this.agetextBox.TabIndex = 6;
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.Location = new System.Drawing.Point(6, 31);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(47, 17);
            this.maleradioButton.TabIndex = 8;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "male";
            this.maleradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.femaleradioButton2);
            this.groupBox.Controls.Add(this.maleradioButton);
            this.groupBox.Location = new System.Drawing.Point(510, 39);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(156, 111);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Gender";
            // 
            // femaleradioButton2
            // 
            this.femaleradioButton2.AutoSize = true;
            this.femaleradioButton2.Location = new System.Drawing.Point(6, 55);
            this.femaleradioButton2.Name = "femaleradioButton2";
            this.femaleradioButton2.Size = new System.Drawing.Size(56, 17);
            this.femaleradioButton2.TabIndex = 9;
            this.femaleradioButton2.TabStop = true;
            this.femaleradioButton2.Text = "female";
            this.femaleradioButton2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(187, 301);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.agetextBox);
            this.Controls.Add(this.surnametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.button);
            this.Name = "form1";
            this.Text = "Elvin\'s App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnametextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton femaleradioButton2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

