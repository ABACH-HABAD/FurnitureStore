namespace FurnitureStore.Forms
{
    partial class FurnitureEditForm
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
            textBox1 = new TextBox();
            PriceBox = new TextBox();
            NameBox = new Label();
            label2 = new Label();
            DescBox = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            AcceptButton = new Button();
            DenyButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(268, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 34);
            textBox1.TabIndex = 0;
            // 
            // PriceBox
            // 
            PriceBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PriceBox.Font = new Font("Segoe UI", 15F);
            PriceBox.Location = new Point(268, 58);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(259, 34);
            PriceBox.TabIndex = 1;
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Left;
            NameBox.AutoSize = true;
            NameBox.Font = new Font("Segoe UI", 15F);
            NameBox.Location = new Point(3, 11);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(104, 28);
            NameBox.TabIndex = 2;
            NameBox.Text = "Название:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Цена";
            // 
            // DescBox
            // 
            DescBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescBox.Font = new Font("Segoe UI", 15F);
            DescBox.Location = new Point(268, 103);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(259, 34);
            DescBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(3, 100);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 5;
            label1.Text = "Описание";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NameBox, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(PriceBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(AcceptButton, 0, 3);
            tableLayoutPanel1.Controls.Add(DenyButton, 1, 3);
            tableLayoutPanel1.Controls.Add(DescBox, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(530, 251);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // AcceptButton
            // 
            AcceptButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptButton.BackColor = Color.FromArgb(192, 255, 192);
            AcceptButton.Font = new Font("Segoe UI", 15F);
            AcceptButton.Location = new Point(3, 203);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(259, 45);
            AcceptButton.TabIndex = 6;
            AcceptButton.Text = "Подтвердить";
            AcceptButton.UseVisualStyleBackColor = false;
            // 
            // DenyButton
            // 
            DenyButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DenyButton.BackColor = Color.FromArgb(255, 192, 192);
            DenyButton.Font = new Font("Segoe UI", 15F);
            DenyButton.Location = new Point(268, 203);
            DenyButton.Name = "DenyButton";
            DenyButton.Size = new Size(259, 45);
            DenyButton.TabIndex = 7;
            DenyButton.Text = "Отменить";
            DenyButton.UseVisualStyleBackColor = false;
            // 
            // FurnitureEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 251);
            Controls.Add(tableLayoutPanel1);
            Name = "FurnitureEditForm";
            Text = "FurnitureEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox PriceBox;
        private Label NameBox;
        private Label label2;
        private TextBox DescBox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AcceptButton;
        private Button DenyButton;
    }
}