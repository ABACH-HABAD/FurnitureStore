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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(22, 18);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(22, 56);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // NameTextBlock
            // 
            NameTextBlock.AutoSize = true;
            NameTextBlock.Font = new Font("Segoe UI", 15F);
            NameTextBlock.Location = new Point(142, 18);
            NameTextBlock.Margin = new Padding(10, 0, 10, 0);
            NameTextBlock.Name = "NameTextBlock";
            NameTextBlock.Size = new Size(0, 28);
            NameTextBlock.TabIndex = 2;
            // 
            // PriceTextBlock
            // 
            PriceTextBlock.AutoSize = true;
            PriceTextBlock.Font = new Font("Segoe UI", 15F);
            PriceTextBlock.Location = new Point(142, 56);
            PriceTextBlock.Margin = new Padding(10, 0, 10, 0);
            PriceTextBlock.Name = "PriceTextBlock";
            PriceTextBlock.Size = new Size(0, 28);
            PriceTextBlock.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(22, 94);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 4;
            label3.Text = "Описание";
            // 
            // DesctiptionTextBlock
            // 
            DesctiptionTextBlock.AutoSize = true;
            DesctiptionTextBlock.Font = new Font("Segoe UI", 15F);
            DesctiptionTextBlock.Location = new Point(22, 122);
            DesctiptionTextBlock.Margin = new Padding(10, 0, 10, 0);
            DesctiptionTextBlock.Name = "DesctiptionTextBlock";
            DesctiptionTextBlock.Size = new Size(0, 28);
            DesctiptionTextBlock.TabIndex = 5;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 15F);
            EditButton.Location = new Point(22, 211);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(160, 48);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(255, 192, 192);
            DeleteButton.Font = new Font("Segoe UI", 15F);
            DeleteButton.Location = new Point(188, 211);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(160, 48);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(DesctiptionTextBlock);
            Controls.Add(label3);
            Controls.Add(PriceTextBlock);
            Controls.Add(NameTextBlock);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductUserControl";
            Size = new Size(390, 269);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
