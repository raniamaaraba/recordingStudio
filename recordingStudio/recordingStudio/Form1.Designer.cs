namespace recordingStudio
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupTotalTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.totalTotalTextBox = new System.Windows.Forms.TextBox();
            this.groupsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(187, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(119, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 97);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Minutes used:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTotalTextBox);
            this.groupBox1.Controls.Add(this.averageTextBox);
            this.groupBox1.Controls.Add(this.groupTotalTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chargeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(365, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charges:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.Location = new System.Drawing.Point(217, 37);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.ReadOnly = true;
            this.chargeTextBox.Size = new System.Drawing.Size(100, 27);
            this.chargeTextBox.TabIndex = 5;
            this.chargeTextBox.TabStop = false;
            this.chargeTextBox.TextChanged += new System.EventHandler(this.chargeTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average Change";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total charges for group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average Charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Charges for all groups";
            // 
            // groupTotalTextBox
            // 
            this.groupTotalTextBox.Location = new System.Drawing.Point(217, 70);
            this.groupTotalTextBox.Name = "groupTotalTextBox";
            this.groupTotalTextBox.ReadOnly = true;
            this.groupTotalTextBox.Size = new System.Drawing.Size(100, 27);
            this.groupTotalTextBox.TabIndex = 10;
            this.groupTotalTextBox.TabStop = false;
            this.groupTotalTextBox.TextChanged += new System.EventHandler(this.groupTotalTextBox_TextChanged);
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(217, 103);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(100, 27);
            this.averageTextBox.TabIndex = 11;
            this.averageTextBox.TabStop = false;
            // 
            // totalTotalTextBox
            // 
            this.totalTotalTextBox.Location = new System.Drawing.Point(217, 136);
            this.totalTotalTextBox.Name = "totalTotalTextBox";
            this.totalTotalTextBox.ReadOnly = true;
            this.totalTotalTextBox.Size = new System.Drawing.Size(100, 27);
            this.totalTotalTextBox.TabIndex = 12;
            this.totalTotalTextBox.TabStop = false;
            // 
            // groupsTextBox
            // 
            this.groupsTextBox.Location = new System.Drawing.Point(187, 174);
            this.groupsTextBox.Name = "groupsTextBox";
            this.groupsTextBox.Size = new System.Drawing.Size(119, 23);
            this.groupsTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Number of Groups";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 308);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(80, 47);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 361);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 47);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(98, 308);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(80, 47);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(98, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 47);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupsTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Label nameLabel;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox chargeTextBox;
        private TextBox groupTotalTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox totalTotalTextBox;
        private TextBox averageTextBox;
        private TextBox groupsTextBox;
        private Label label6;
        private Button calcButton;
        private Button ClearButton;
        private Button printButton;
        private Button exitButton;
    }
}