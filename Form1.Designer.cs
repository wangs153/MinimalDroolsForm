namespace MinimalDroolsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Test for Git

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.debugOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DaysSinceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.ScenarioButton1 = new System.Windows.Forms.RadioButton();
            this.ScenarioButton2 = new System.Windows.Forms.RadioButton();
            this.ScenarioButton3 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run Rules";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(155, 21);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(50, 20);
            this.qtyTextBox.TabIndex = 3;
            this.qtyTextBox.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "QTY";
            // 
            // debugOutput
            // 
            this.debugOutput.Location = new System.Drawing.Point(12, 128);
            this.debugOutput.Name = "debugOutput";
            this.debugOutput.Size = new System.Drawing.Size(379, 239);
            this.debugOutput.TabIndex = 5;
            this.debugOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(52, 21);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(50, 20);
            this.IDTextBox.TabIndex = 7;
            this.IDTextBox.Text = "111-111";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Days Since Last Order";
            // 
            // DaysSinceTextBox
            // 
            this.DaysSinceTextBox.Location = new System.Drawing.Point(155, 56);
            this.DaysSinceTextBox.Name = "DaysSinceTextBox";
            this.DaysSinceTextBox.Size = new System.Drawing.Size(50, 20);
            this.DaysSinceTextBox.TabIndex = 9;
            this.DaysSinceTextBox.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(78, 88);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(127, 20);
            this.StatusTextBox.TabIndex = 11;
            this.StatusTextBox.Text = "NORMAL";
            // 
            // ScenarioButton1
            // 
            this.ScenarioButton1.AutoSize = true;
            this.ScenarioButton1.Checked = true;
            this.ScenarioButton1.Location = new System.Drawing.Point(291, 23);
            this.ScenarioButton1.Name = "ScenarioButton1";
            this.ScenarioButton1.Size = new System.Drawing.Size(76, 17);
            this.ScenarioButton1.TabIndex = 12;
            this.ScenarioButton1.TabStop = true;
            this.ScenarioButton1.Text = "Scenario 1";
            this.ScenarioButton1.UseVisualStyleBackColor = true;
            this.ScenarioButton1.CheckedChanged += new System.EventHandler(this.ScenarioButton1_CheckedChanged);
            // 
            // ScenarioButton2
            // 
            this.ScenarioButton2.AutoSize = true;
            this.ScenarioButton2.Location = new System.Drawing.Point(291, 58);
            this.ScenarioButton2.Name = "ScenarioButton2";
            this.ScenarioButton2.Size = new System.Drawing.Size(76, 17);
            this.ScenarioButton2.TabIndex = 13;
            this.ScenarioButton2.Text = "Scenario 2";
            this.ScenarioButton2.UseVisualStyleBackColor = true;
            this.ScenarioButton2.CheckedChanged += new System.EventHandler(this.ScenarioButton2_CheckedChanged);
            // 
            // ScenarioButton3
            // 
            this.ScenarioButton3.AutoSize = true;
            this.ScenarioButton3.Location = new System.Drawing.Point(291, 90);
            this.ScenarioButton3.Name = "ScenarioButton3";
            this.ScenarioButton3.Size = new System.Drawing.Size(76, 17);
            this.ScenarioButton3.TabIndex = 14;
            this.ScenarioButton3.Text = "Scenario 3";
            this.ScenarioButton3.UseVisualStyleBackColor = true;
            this.ScenarioButton3.CheckedChanged += new System.EventHandler(this.ScenarioButton3_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 408);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ScenarioButton3);
            this.Controls.Add(this.ScenarioButton2);
            this.Controls.Add(this.ScenarioButton1);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DaysSinceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.debugOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Drools.Net Test Form";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox debugOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DaysSinceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.RadioButton ScenarioButton1;
        private System.Windows.Forms.RadioButton ScenarioButton2;
        private System.Windows.Forms.RadioButton ScenarioButton3;
        private System.Windows.Forms.Button button3;
    }
}

