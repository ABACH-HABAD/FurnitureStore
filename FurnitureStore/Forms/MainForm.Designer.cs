namespace FurnitureStore
{
    partial class MainForm
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ShowSalesButton = new Button();
            ShowBtwShitBotton = new Button();
            priceHistoryGraphControl1 = new FurnitureStore.Controls.Gdi.PriceHistoryGraphControl();
            salesCountsGraphControl1 = new FurnitureStore.Controls.Gdi.SalesCountsGraphControl();
            ListOfProducts = new FurnitureStore.Controls.UserControls.ListOfProductsUserControl();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(206, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(197, 137);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать в систему контроля мебельного магзина";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(ShowSalesButton, 0, 1);
            tableLayoutPanel1.Controls.Add(ShowBtwShitBotton, 0, 2);
            tableLayoutPanel1.Controls.Add(priceHistoryGraphControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(salesCountsGraphControl1, 2, 0);
            tableLayoutPanel1.Controls.Add(ListOfProducts, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(609, 412);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ShowSalesButton
            // 
            ShowSalesButton.Anchor = AnchorStyles.None;
            ShowSalesButton.Location = new Point(36, 175);
            ShowSalesButton.Name = "ShowSalesButton";
            ShowSalesButton.Size = new Size(130, 61);
            ShowSalesButton.TabIndex = 1;
            ShowSalesButton.Text = "Посмотреть список товаров";
            ShowSalesButton.UseVisualStyleBackColor = true;
            ShowSalesButton.Click += ShowSalesButtonClick;
            // 
            // ShowBtwShitBotton
            // 
            ShowBtwShitBotton.Anchor = AnchorStyles.None;
            ShowBtwShitBotton.Location = new Point(36, 312);
            ShowBtwShitBotton.Name = "ShowBtwShitBotton";
            ShowBtwShitBotton.Size = new Size(130, 61);
            ShowBtwShitBotton.TabIndex = 2;
            ShowBtwShitBotton.Text = "Посмотреть список товаров";
            ShowBtwShitBotton.UseVisualStyleBackColor = true;
            ShowBtwShitBotton.Click += ShowBtwShitBotton_Click;
            // 
            // priceHistoryGraphControl1
            // 
            priceHistoryGraphControl1.Dock = DockStyle.Fill;
            priceHistoryGraphControl1.Location = new Point(3, 3);
            priceHistoryGraphControl1.Name = "priceHistoryGraphControl1";
            priceHistoryGraphControl1.PlotBottom = 40F;
            priceHistoryGraphControl1.PlotLeft = 60F;
            priceHistoryGraphControl1.PlotRight = 20F;
            priceHistoryGraphControl1.PlotTop = 10F;
            priceHistoryGraphControl1.Size = new Size(197, 131);
            priceHistoryGraphControl1.TabIndex = 3;
            priceHistoryGraphControl1.Text = "priceHistoryGraphControl1";
            // 
            // salesCountsGraphControl1
            // 
            salesCountsGraphControl1.BackgroundImageLayout = ImageLayout.None;
            salesCountsGraphControl1.Dock = DockStyle.Fill;
            salesCountsGraphControl1.Location = new Point(409, 3);
            salesCountsGraphControl1.Name = "salesCountsGraphControl1";
            salesCountsGraphControl1.PlotBottom = 40F;
            salesCountsGraphControl1.PlotLeft = 60F;
            salesCountsGraphControl1.PlotRight = 20F;
            salesCountsGraphControl1.PlotTop = 10F;
            salesCountsGraphControl1.Size = new Size(197, 131);
            salesCountsGraphControl1.TabIndex = 4;
            salesCountsGraphControl1.Text = "salesCountsGraphControl1";
            // 
            // ListOfProducts
            // 
            ListOfProducts.Dock = DockStyle.Fill;
            ListOfProducts.Location = new Point(206, 140);
            ListOfProducts.Name = "ListOfProducts";
            ListOfProducts.Size = new Size(197, 131);
            ListOfProducts.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(609, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 436);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(625, 475);
            Name = "MainForm";
            Text = "ИС \"Мебельный магазин\"";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private Button ShowSalesButton;
        private Button ShowBtwShitBotton;
        private Controls.Gdi.PriceHistoryGraphControl priceHistoryGraphControl1;
        private Controls.Gdi.SalesCountsGraphControl salesCountsGraphControl1;
        private Controls.UserControls.ListOfProductsUserControl ListOfProducts;
    }
}
