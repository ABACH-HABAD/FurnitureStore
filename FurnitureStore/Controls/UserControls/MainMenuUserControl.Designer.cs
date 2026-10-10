namespace FurnitureStore.Controls.UserControls
{
    partial class MainMenuUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            ExitButton = new Button();
            ShowProductListButton = new Button();
            label1 = new Label();
            GenerateSalesReportButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(ExitButton, 0, 3);
            tableLayoutPanel1.Controls.Add(ShowProductListButton, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(GenerateSalesReportButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(830, 449);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.None;
            ExitButton.Location = new Point(350, 362);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 61);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ShowProductListButton
            // 
            ShowProductListButton.Anchor = AnchorStyles.None;
            ShowProductListButton.Location = new Point(350, 137);
            ShowProductListButton.Name = "ShowProductListButton";
            ShowProductListButton.Size = new Size(130, 61);
            ShowProductListButton.TabIndex = 4;
            ShowProductListButton.Text = "Посмотреть список товаров";
            ShowProductListButton.UseVisualStyleBackColor = true;
            ShowProductListButton.Click += ShowProductListButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(824, 112);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать в систему контроля мебельного магзина";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GenerateSalesReportButton
            // 
            GenerateSalesReportButton.Anchor = AnchorStyles.None;
            GenerateSalesReportButton.Location = new Point(350, 249);
            GenerateSalesReportButton.Name = "GenerateSalesReportButton";
            GenerateSalesReportButton.Size = new Size(130, 61);
            GenerateSalesReportButton.TabIndex = 3;
            GenerateSalesReportButton.Text = "Сформировать отчёт о продажах";
            GenerateSalesReportButton.UseVisualStyleBackColor = true;
            GenerateSalesReportButton.Click += GenerateSalesReportButton_Click;
            // 
            // MainMenuUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MainMenuUserControl";
            Size = new Size(830, 449);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button ExitButton;
        private Button ShowProductListButton;
        private Button GenerateSalesReportButton;
    }
}
