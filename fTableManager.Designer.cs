
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            cbFood = new ComboBox();
            btnAddFood = new Button();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1063, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân ";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất ";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new System.Drawing.Point(586, 135);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(465, 391);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.HideSelection = false;
            lsvBill.Location = new System.Drawing.Point(-3, 0);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new System.Drawing.Size(468, 391);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
         
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new System.Drawing.Point(586, 532);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(465, 74);
            panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txbTotalPrice.ForeColor = System.Drawing.Color.Tomato;
            txbTotalPrice.Location = new System.Drawing.Point(213, 22);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new System.Drawing.Size(139, 30);
            txbTotalPrice.TabIndex = 8;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new System.Drawing.Point(3, 39);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new System.Drawing.Size(94, 28);
            cbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new System.Drawing.Size(94, 33);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new System.Drawing.Point(103, 39);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new System.Drawing.Size(94, 27);
            nmDiscount.TabIndex = 5;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new System.Drawing.Point(103, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new System.Drawing.Size(94, 33);
            btnDiscount.TabIndex = 4;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new System.Drawing.Point(371, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(94, 64);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new System.Drawing.Point(586, 31);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(465, 85);
            panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new System.Drawing.Point(390, 23);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new System.Drawing.Size(72, 27);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new System.Drawing.Point(3, 37);
            cbFood.Name = "cbFood";
            cbFood.Size = new System.Drawing.Size(259, 28);
            cbFood.TabIndex = 1;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new System.Drawing.Point(280, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new System.Drawing.Size(94, 64);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm món ";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(259, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.Location = new System.Drawing.Point(12, 34);
            flpTable.Name = "flpTable";
            flpTable.Size = new System.Drawing.Size(568, 572);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1063, 643);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán Cafe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            flpTable.Paint += flpTable_Paint;
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDiscount;
        private Button btnDiscount;
        private Button btnCheckOut;
        private FlowLayoutPanel flpTable;
        private PaintEventHandler flpTable_Paint;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
    }
}