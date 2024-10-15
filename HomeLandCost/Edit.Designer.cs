namespace HomeLandCost
{
    partial class Edit
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
            label4 = new Label();
            Price = new TextBox();
            pr = new Label();
            Name = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(438, 80);
            label4.Name = "label4";
            label4.Size = new Size(336, 65);
            label4.TabIndex = 43;
            label4.Text = "HomeLand.az";
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(472, 306);
            Price.Name = "Price";
            Price.Size = new Size(284, 25);
            Price.TabIndex = 42;
            // 
            // pr
            // 
            pr.AutoSize = true;
            pr.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pr.Location = new Point(571, 288);
            pr.Name = "pr";
            pr.Size = new Size(38, 15);
            pr.TabIndex = 41;
            pr.Text = "Price:";
            // 
            // Name
            // 
            Name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(472, 249);
            Name.Name = "Name";
            Name.Size = new Size(284, 25);
            Name.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(571, 231);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 31;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(571, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 30;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 619);
            Controls.Add(label4);
            Controls.Add(Price);
            Controls.Add(pr);
            Controls.Add(Name);
            Controls.Add(label1);
            Controls.Add(button1);
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox Price;
        private Label pr;
        private TextBox Name;
        private Label label1;
        private Button button1;
    }
}