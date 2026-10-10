namespace FurnitureStore.Controls.UserControls
{
    partial class ListOfProductsUserControl
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
            FlowPanel = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            CreateButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // FlowPanel
            // 
            FlowPanel.AutoScroll = true;
            FlowPanel.Dock = DockStyle.Fill;
            FlowPanel.Location = new Point(3, 3);
            FlowPanel.Name = "FlowPanel";
            FlowPanel.Size = new Size(493, 408);
            FlowPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(FlowPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(CreateButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(499, 460);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // CreateButton
            // 
            CreateButton.Dock = DockStyle.Fill;
            CreateButton.Location = new Point(3, 417);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(493, 40);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Добавить";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ListOfProductsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ListOfProductsUserControl";
            Size = new Size(499, 460);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button CreateButton;
    }
}
