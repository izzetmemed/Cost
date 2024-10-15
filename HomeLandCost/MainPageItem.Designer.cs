namespace HomeLandCost
{
    partial class MainPageItem
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            Name = new TextBox();
            hh = new Label();
            Price = new TextBox();
            jsjd = new Label();
            GridData = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            button6 = new Button();
            button1 = new Button();
            label3 = new Label();
            AllPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(-92, 176);
            button5.Name = "button5";
            button5.Size = new Size(80, 37);
            button5.TabIndex = 39;
            button5.Text = "Word";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(633, 294);
            button4.Name = "button4";
            button4.Size = new Size(133, 37);
            button4.TabIndex = 38;
            button4.Text = "All";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(459, 294);
            button3.Name = "button3";
            button3.Size = new Size(150, 37);
            button3.TabIndex = 37;
            button3.Text = "Month";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(449, -62);
            label4.Name = "label4";
            label4.Size = new Size(336, 65);
            label4.TabIndex = 36;
            label4.Text = "HomeLand.az";
            // 
            // Name
            // 
            Name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(536, 199);
            Name.Name = "Name";
            Name.Size = new Size(174, 25);
            Name.TabIndex = 31;
            // 
            // hh
            // 
            hh.AutoSize = true;
            hh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hh.Location = new Point(536, 122);
            hh.Name = "hh";
            hh.Size = new Size(96, 15);
            hh.TabIndex = 30;
            hh.Text = "Əşyanın qiyməti:";
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(536, 140);
            Price.Name = "Price";
            Price.Size = new Size(174, 25);
            Price.TabIndex = 29;
            // 
            // jsjd
            // 
            jsjd.AutoSize = true;
            jsjd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jsjd.Location = new Point(536, 181);
            jsjd.Name = "jsjd";
            jsjd.Size = new Size(74, 15);
            jsjd.TabIndex = 28;
            jsjd.Text = "Əşyanın adı:";
            // 
            // GridData
            // 
            GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridData.Location = new Point(275, 337);
            GridData.Name = "GridData";
            GridData.RowTemplate.Height = 25;
            GridData.Size = new Size(717, 252);
            GridData.TabIndex = 25;
            GridData.CellContentClick += GridData_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 129);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 23;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 66);
            button2.Name = "button2";
            button2.Size = new Size(122, 37);
            button2.TabIndex = 40;
            button2.Text = "Word";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(442, 27);
            label1.Name = "label1";
            label1.Size = new Size(336, 65);
            label1.TabIndex = 41;
            label1.Text = "HomeLand.az";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(536, 242);
            button6.Name = "button6";
            button6.Size = new Size(174, 37);
            button6.TabIndex = 42;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 43;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 316);
            label3.Name = "label3";
            label3.Size = new Size(108, 29);
            label3.TabIndex = 45;
            label3.Text = "All Price:";
            // 
            // AllPrice
            // 
            AllPrice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AllPrice.Location = new Point(96, 348);
            AllPrice.Name = "AllPrice";
            AllPrice.Size = new Size(111, 34);
            AllPrice.TabIndex = 44;
            // 
            // MainPageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 498);
            Controls.Add(label3);
            Controls.Add(AllPrice);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(Name);
            Controls.Add(hh);
            Controls.Add(Price);
            Controls.Add(jsjd);
            Controls.Add(GridData);
            Controls.Add(label2);
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Label label4;
        private TextBox Name;
        private Label hh;
        private TextBox Price;
        private Label jsjd;
        private DataGridView GridData;
        private Label label2;
        private Button button2;
        private Label label1;
        private Button button6;
        private Button button1;
        private Label label3;
        private TextBox AllPrice;
    }
}