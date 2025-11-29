namespace ExCafeIC
{
    partial class CafeIC
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
            BTClear = new Button();
            BTEdit = new Button();
            BTDel = new Button();
            BTAdd = new Button();
            LBSum = new Label();
            NUDNum = new NumericUpDown();
            LBPrice = new Label();
            CBOrder = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LVOrder = new ListView();
            Ordername = new ColumnHeader();
            Orderprice = new ColumnHeader();
            Ordernum = new ColumnHeader();
            OrderSum = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)NUDNum).BeginInit();
            SuspendLayout();
            // 
            // BTClear
            // 
            BTClear.Location = new Point(796, 559);
            BTClear.Margin = new Padding(4, 3, 4, 3);
            BTClear.Name = "BTClear";
            BTClear.Size = new Size(139, 48);
            BTClear.TabIndex = 26;
            BTClear.Text = "ล้างข้อมูล";
            BTClear.UseVisualStyleBackColor = true;
            BTClear.Click += BTClear_Click;
            // 
            // BTEdit
            // 
            BTEdit.Location = new Point(584, 559);
            BTEdit.Margin = new Padding(4, 3, 4, 3);
            BTEdit.Name = "BTEdit";
            BTEdit.Size = new Size(139, 48);
            BTEdit.TabIndex = 25;
            BTEdit.Text = "แก้ไขข้อมูล";
            BTEdit.UseVisualStyleBackColor = true;
            BTEdit.Click += BTEdit_Click;
            // 
            // BTDel
            // 
            BTDel.Location = new Point(389, 559);
            BTDel.Margin = new Padding(4, 3, 4, 3);
            BTDel.Name = "BTDel";
            BTDel.Size = new Size(139, 48);
            BTDel.TabIndex = 24;
            BTDel.Text = "ลบข้อมูล";
            BTDel.UseVisualStyleBackColor = true;
            BTDel.Click += BTDel_Click;
            // 
            // BTAdd
            // 
            BTAdd.Location = new Point(175, 559);
            BTAdd.Margin = new Padding(4, 3, 4, 3);
            BTAdd.Name = "BTAdd";
            BTAdd.Size = new Size(139, 48);
            BTAdd.TabIndex = 23;
            BTAdd.Text = "เพิ่มข้อมูล";
            BTAdd.UseVisualStyleBackColor = true;
            BTAdd.Click += BTAdd_Click;
            // 
            // LBSum
            // 
            LBSum.BackColor = Color.SteelBlue;
            LBSum.ForeColor = SystemColors.ControlText;
            LBSum.Location = new Point(817, 501);
            LBSum.Margin = new Padding(4, 0, 4, 0);
            LBSum.Name = "LBSum";
            LBSum.Size = new Size(94, 23);
            LBSum.TabIndex = 22;
            LBSum.Text = "0";
            LBSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NUDNum
            // 
            NUDNum.Location = new Point(649, 501);
            NUDNum.Margin = new Padding(4, 3, 4, 3);
            NUDNum.Name = "NUDNum";
            NUDNum.Size = new Size(122, 23);
            NUDNum.TabIndex = 21;
            NUDNum.ValueChanged += NUDNum_ValueChanged;
            // 
            // LBPrice
            // 
            LBPrice.BackColor = SystemColors.ActiveCaptionText;
            LBPrice.ForeColor = SystemColors.ControlLightLight;
            LBPrice.Location = new Point(468, 500);
            LBPrice.Margin = new Padding(4, 0, 4, 0);
            LBPrice.Name = "LBPrice";
            LBPrice.Size = new Size(135, 24);
            LBPrice.TabIndex = 20;
            LBPrice.Text = "0";
            LBPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CBOrder
            // 
            CBOrder.FormattingEnabled = true;
            CBOrder.Items.AddRange(new object[] { "ไอติมรสช็อคโกแลต", "ไอติมรสวนิลา", "ไอติมรสชาไทย", "ไอติมรสสตอเบอรี่", "ไอติมรสชาเขียว", "ไอติมรสส้ม", "ไอติมรสโอริโอ้", "ไอติมรสช็อคชิพ", "ไอติมรสมะนาว", "ไอติมรสนมสด", "ไอติมรสมะม่วง", "ไอติมรสกระปิ", "ไอติมรสมะพร้าว", "ไอติมรสกล้วย", "ไอติมรสแตงโม" });
            CBOrder.Location = new Point(111, 496);
            CBOrder.Margin = new Padding(4, 3, 4, 3);
            CBOrder.Name = "CBOrder";
            CBOrder.Size = new Size(308, 23);
            CBOrder.TabIndex = 19;
            CBOrder.SelectedIndexChanged += CBOrder_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(817, 456);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 18;
            label4.Text = "ราคารวม";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(645, 456);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "จำนวนสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 456);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 16;
            label2.Text = "ราคาต่อหน่วย";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 456);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 15;
            label1.Text = "รายการสินค้า";
            // 
            // LVOrder
            // 
            LVOrder.Columns.AddRange(new ColumnHeader[] { Ordername, Orderprice, Ordernum, OrderSum });
            LVOrder.FullRowSelect = true;
            LVOrder.GridLines = true;
            LVOrder.Location = new Point(111, 50);
            LVOrder.Margin = new Padding(4, 3, 4, 3);
            LVOrder.MultiSelect = false;
            LVOrder.Name = "LVOrder";
            LVOrder.Size = new Size(887, 357);
            LVOrder.TabIndex = 14;
            LVOrder.UseCompatibleStateImageBehavior = false;
            LVOrder.View = View.Details;
            LVOrder.SelectedIndexChanged += LVOrder_SelectedIndexChanged;
            LVOrder.MouseDoubleClick += LVOrder_MouseDoubleClick;
            // 
            // Ordername
            // 
            Ordername.Text = "รายการสินค้า";
            Ordername.Width = 300;
            // 
            // Orderprice
            // 
            Orderprice.Text = "ราคาต่อหน่วย";
            Orderprice.Width = 150;
            // 
            // Ordernum
            // 
            Ordernum.Text = "จำนวนสินค้า";
            Ordernum.Width = 150;
            // 
            // OrderSum
            // 
            OrderSum.Text = "ราคารวม";
            OrderSum.Width = 150;
            // 
            // CafeIC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 657);
            Controls.Add(BTClear);
            Controls.Add(BTEdit);
            Controls.Add(BTDel);
            Controls.Add(BTAdd);
            Controls.Add(LBSum);
            Controls.Add(NUDNum);
            Controls.Add(LBPrice);
            Controls.Add(CBOrder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LVOrder);
            Name = "CafeIC";
            Text = "CafeIC";
            Load += CafeIC_Load;
            Click += CafeIC_Click;
            ((System.ComponentModel.ISupportInitialize)NUDNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTClear;
        private Button BTEdit;
        private Button BTDel;
        private Button BTAdd;
        private Label LBSum;
        private NumericUpDown NUDNum;
        private Label LBPrice;
        private ComboBox CBOrder;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView LVOrder;
        private ColumnHeader Ordername;
        private ColumnHeader Orderprice;
        private ColumnHeader Ordernum;
        private ColumnHeader OrderSum;
    }
}