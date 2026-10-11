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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            менюToolStripMenuItem = new ToolStripMenuItem();
            списокТоваровToolStripMenuItem = new ToolStripMenuItem();
            OpenProductListToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            OpenSaleGraphToolStripMenuItem = new ToolStripMenuItem();
            OpenMainMenuToolStripMenuItem = new ToolStripMenuItem();
            ControlPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(609, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(108, 22);
            ExitToolStripMenuItem.Text = "Выход";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { списокТоваровToolStripMenuItem, OpenSaleGraphToolStripMenuItem, OpenMainMenuToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // списокТоваровToolStripMenuItem
            // 
            списокТоваровToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenProductListToolStripMenuItem, добавитьToolStripMenuItem });
            списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            списокТоваровToolStripMenuItem.Size = new Size(180, 22);
            списокТоваровToolStripMenuItem.Text = "Список товаров";
            // 
            // OpenProductListToolStripMenuItem
            // 
            OpenProductListToolStripMenuItem.Name = "OpenProductListToolStripMenuItem";
            OpenProductListToolStripMenuItem.Size = new Size(126, 22);
            OpenProductListToolStripMenuItem.Text = "Открыть";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(126, 22);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // OpenSaleGraphToolStripMenuItem
            // 
            OpenSaleGraphToolStripMenuItem.Name = "OpenSaleGraphToolStripMenuItem";
            OpenSaleGraphToolStripMenuItem.Size = new Size(180, 22);
            OpenSaleGraphToolStripMenuItem.Text = "Отчёт о продажах";
            // 
            // OpenMainMenuToolStripMenuItem
            // 
            OpenMainMenuToolStripMenuItem.Name = "OpenMainMenuToolStripMenuItem";
            OpenMainMenuToolStripMenuItem.Size = new Size(180, 22);
            OpenMainMenuToolStripMenuItem.Text = "Главное меню";
            // 
            // ControlPanel
            // 
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.Location = new Point(0, 24);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(609, 412);
            ControlPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 436);
            Controls.Add(ControlPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(625, 475);
            Name = "MainForm";
            Text = "ИС \"Мебельный магазин\"";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem списокТоваровToolStripMenuItem;
        private ToolStripMenuItem OpenProductListToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem OpenSaleGraphToolStripMenuItem;
        private ToolStripMenuItem OpenMainMenuToolStripMenuItem;
        private Panel ControlPanel;
    }
}
