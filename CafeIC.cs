using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCafeIC
{
    public partial class CafeIC : Form
    {
        public CafeIC()
        {
            InitializeComponent();
        }

        ListViewItem lvi = default(ListViewItem);

        private void CafeIC_Load(object sender, EventArgs e)
        {
            BTDel.Enabled = false;
            BTEdit.Enabled = false;
        }
        private void Cal()
        {
            double Price = 0, Num, Sum;
            int id = CBOrder.SelectedIndex;
                if (id >= 0) 
            {
                Price = 20;
            }
            Num = Convert.ToDouble(NUDNum.Value);
            Sum = Price * Num;
            LBPrice.Text = Price.ToString();
            LBSum.Text = Sum.ToString();
        }

        private void NUDNum_ValueChanged(object sender, EventArgs e)
        {
            Cal();
        }

        private void CBOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cal();
        }

        private void C1()
        {
            CBOrder.SelectedIndex = -1;
            LBPrice.Text = "0";
            NUDNum.Value = 0;
            LBSum.Text = "0";
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            if (CBOrder.SelectedIndex != -1)
            {
                if (NUDNum.Value > 0)
                {
                    lvi = LVOrder.Items.Add(CBOrder.Text);
                    lvi.SubItems.Add(LBPrice.Text);
                    lvi.SubItems.Add(NUDNum.Value.ToString());
                    lvi.SubItems.Add(LBSum.Text);
                }
                else
                {
                    MessageBox.Show("กรุณาใส่จำนวนสินค้า", "มีข้อผิดพลาด");
                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่ชนิดสินค้า", "มีข้อผิดพลาด");
            }
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            string MS = "ยืนยันการลบข้อมูล Yes/No";
            string HD = "ลบข้อมูลทั้งหมด";
            MessageBoxButtons BT = MessageBoxButtons.YesNo;
            DialogResult Result = MessageBox.Show(MS, HD, BT);
            if (Result == DialogResult.Yes)
            {
                LVOrder.Items.Clear();
                MessageBox.Show("ลบข้อมูลทั้งหมดสำเร็จ", "แจ้งผล");
            }
        }

        private void LVOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTAdd.Enabled = false;
            BTEdit.Enabled = false;
            BTDel.Enabled = true;
        }

        private void CafeIC_Click(object sender, EventArgs e)
        {
            BTAdd.Enabled = true;
            BTEdit.Enabled = false;
            BTDel.Enabled = false;
        }

        private void BTDel_Click(object sender, EventArgs e)
        {
            string MS = "ยืนยันการลบข้อมูล Yes/No";
            string HD = "ลบข้อมูล";
            MessageBoxButtons BT = MessageBoxButtons.YesNo;
            DialogResult Result = MessageBox.Show(MS, HD, BT);
            if (Result == DialogResult.Yes)
            {
                lvi = LVOrder.SelectedItems[0];
                lvi.Remove();
            }
            BTAdd.Enabled = true;
            BTEdit.Enabled = false;
            BTDel.Enabled = false;
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            string MS = "ยืนยันการแก้ไขข้อมูล Yes/No";
            string HD = "แก้ไขข้อมูล";
            MessageBoxButtons BT = MessageBoxButtons.YesNo;
            DialogResult Result = MessageBox.Show(MS, HD, BT);
            if (Result == DialogResult.Yes)
            {
                lvi.Text = CBOrder.Text;
                lvi.SubItems[1].Text = LBPrice.Text;
                lvi.SubItems[2].Text = NUDNum.Value.ToString();
                lvi.SubItems[3].Text = LBSum.Text;
                C1();
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "แจ้งยืนยัน");
            }
            BTAdd.Enabled = true;
            BTEdit.Enabled = false;
            BTDel.Enabled = false;
        }

        private void LVOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lvi = LVOrder.SelectedItems[0];
            CBOrder.Text = lvi.Text;
            LBPrice.Text = lvi.SubItems[1].Text;
            NUDNum.Value = Convert.ToInt16(lvi.SubItems[2].Text);
            LBSum.Text = lvi.SubItems[3].Text;
            BTAdd.Enabled = false;
            BTEdit.Enabled = true;
            BTDel.Enabled = false;
        }
    }
}
