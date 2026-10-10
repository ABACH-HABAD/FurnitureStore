namespace FurnitureStore.Controls.UserControls
{
    partial class ProductUserControl
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
            label1 = new Label();
            label2 = new Label();
            NameTextBlock = new Label();
            PriceTextBlock = new Label();
            label3 = new Label();
            DesctiptionTextBlock = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            tableLayoutPanelUpper = new TableLayoutPanel();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelDown = new TableLayoutPanel();
            tableLayoutPanelUpper.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelDown.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(0, 27);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // NameTextBlock
            // 
            NameTextBlock.AutoSize = true;
            NameTextBlock.Dock = DockStyle.Left;
            NameTextBlock.Font = new Font("Segoe UI", 9F);
            NameTextBlock.Location = new Point(80, 0);
            NameTextBlock.Margin = new Padding(10, 0, 10, 0);
            NameTextBlock.Name = "NameTextBlock";
            NameTextBlock.Size = new Size(0, 27);
            NameTextBlock.TabIndex = 2;
            // 
            // PriceTextBlock
            // 
            PriceTextBlock.AutoSize = true;
            PriceTextBlock.Font = new Font("Segoe UI", 9F);
            PriceTextBlock.Location = new Point(80, 27);
            PriceTextBlock.Margin = new Padding(10, 0, 10, 0);
            PriceTextBlock.Name = "PriceTextBlock";
            PriceTextBlock.Size = new Size(0, 15);
            PriceTextBlock.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(0, 66);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Описание";
            // 
            // DesctiptionTextBlock
            // 
            DesctiptionTextBlock.AutoSize = true;
            DesctiptionTextBlock.Font = new Font("Segoe UI", 9F);
            DesctiptionTextBlock.Location = new Point(10, 81);
            DesctiptionTextBlock.Margin = new Padding(10, 0, 10, 0);
            DesctiptionTextBlock.Name = "DesctiptionTextBlock";
            DesctiptionTextBlock.Size = new Size(0, 15);
            DesctiptionTextBlock.TabIndex = 5;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditButton.Font = new Font("Segoe UI", 9F);
            EditButton.Location = new Point(3, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(101, 24);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteButton.BackColor = Color.FromArgb(255, 192, 192);
            DeleteButton.Font = new Font("Segoe UI", 9F);
            DeleteButton.Location = new Point(110, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(101, 24);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelUpper
            // 
            tableLayoutPanelUpper.ColumnCount = 2;
            tableLayoutPanelUpper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.175354F));
            tableLayoutPanelUpper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.824646F));
            tableLayoutPanelUpper.Controls.Add(DesctiptionTextBlock, 0, 3);
            tableLayoutPanelUpper.Controls.Add(PriceTextBlock, 1, 1);
            tableLayoutPanelUpper.Controls.Add(label3, 0, 2);
            tableLayoutPanelUpper.Controls.Add(NameTextBlock, 1, 0);
            tableLayoutPanelUpper.Controls.Add(label2, 0, 1);
            tableLayoutPanelUpper.Controls.Add(label1, 0, 0);
            tableLayoutPanelUpper.Dock = DockStyle.Fill;
            tableLayoutPanelUpper.Location = new Point(3, 3);
            tableLayoutPanelUpper.Name = "tableLayoutPanelUpper";
            tableLayoutPanelUpper.RowCount = 4;
            tableLayoutPanelUpper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelUpper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelUpper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelUpper.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelUpper.Size = new Size(214, 138);
            tableLayoutPanelUpper.TabIndex = 8;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelDown, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelUpper, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.Size = new Size(220, 180);
            tableLayoutPanelMain.TabIndex = 9;
            // 
            // tableLayoutPanelDown
            // 
            tableLayoutPanelDown.ColumnCount = 2;
            tableLayoutPanelDown.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDown.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDown.Controls.Add(EditButton, 0, 0);
            tableLayoutPanelDown.Controls.Add(DeleteButton, 1, 0);
            tableLayoutPanelDown.Dock = DockStyle.Fill;
            tableLayoutPanelDown.Location = new Point(3, 147);
            tableLayoutPanelDown.Name = "tableLayoutPanelDown";
            tableLayoutPanelDown.RowCount = 1;
            tableLayoutPanelDown.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelDown.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDown.Size = new Size(214, 30);
            tableLayoutPanelDown.TabIndex = 10;
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanelMain);
            Name = "ProductUserControl";
            Size = new Size(220, 180);
            tableLayoutPanelUpper.ResumeLayout(false);
            tableLayoutPanelUpper.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelDown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label NameTextBlock;
        private Label PriceTextBlock;
        private Label label3;
        private Label DesctiptionTextBlock;
        internal Button EditButton;
        internal Button DeleteButton;
        private TableLayoutPanel tableLayoutPanelUpper;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelDown;
    }
}
