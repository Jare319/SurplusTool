using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurplusTool
{
    public partial class Form1 : Form
    {
        public List<SurplusItem> surplusList = new List<SurplusItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = cbox_type.Text;
            if (s == "Laptop" ^ s == "Desktop computer" ^ s == "Tablet" ^ s == "Printer/Fax/Scanner/Copier")
            {
                lbl_flex.Text = "Hard Drive Status:";
                lbl_flex.Visible = true;
                cbox_hdStatus.Visible = true;
                tbox_specify.Visible = false;
                lbl_hdSerial.Visible = true;
                tbox_hdSerial.Visible = true;
            }
            else if (s == "Other (Please Specify)")
            {
                lbl_flex.Text = "Type of Equipment:";
                lbl_flex.Visible = true;
                cbox_hdStatus.Visible = false;
                tbox_specify.Visible = true;
                lbl_hdSerial.Visible = false;
                tbox_hdSerial.Visible = false;
            }
            else
            {
                lbl_flex.Visible = false;
                cbox_hdStatus.Visible = false;
                tbox_specify.Visible = false;
                lbl_hdSerial.Visible = false;
                tbox_hdSerial.Visible = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void clearForm()
        {
            tbox_make.Text = "";
            tbox_model.Text = "";
            tbox_serial.Text = "";
            cbox_type.Text = "";
            cbox_hdStatus.Text = "";
            tbox_specify.Text = "";
            tbox_hdSerial.Text = "";
            lbl_flex.Visible = false;
            cbox_hdStatus.Visible = false;
            tbox_specify.Visible = false;
            tbox_hdSerial.Visible = false;
            lbl_hdSerial.Visible = false;
        }

        private void addItem()
        {
            Boolean add = false;
            if (
                tbox_make.Text != "" &
                tbox_model.Text != "" &
                tbox_serial.Text != "" &
                cbox_type.Text != "")
            {
                if (cbox_type.Text == "Other (Please Specify)" & tbox_specify.Text != "") //for non hard drive items
                {
                    add = true;
                    surplusList.Add(new SurplusItem(tbox_make.Text, tbox_model.Text, tbox_serial.Text, tbox_specify.Text));
                    listBox1.Items.Add(tbox_make.Text + " " + tbox_model.Text + " " + tbox_specify.Text + " S/N:" + tbox_serial.Text);
                }
                else if (cbox_hdStatus.Text != "" & tbox_hdSerial.Text != "")//for hard drive items
                {
                    add = true;
                    surplusList.Add(new SurplusItem(tbox_make.Text, tbox_model.Text, tbox_serial.Text, cbox_type.Text, cbox_hdStatus.Text, tbox_hdSerial.Text));
                    listBox1.Items.Add(tbox_make.Text + " " + tbox_model.Text + " " + cbox_type.Text + " S/N:" + tbox_serial.Text);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please complete all fields");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please complete all fields");
            }
            if (!chkbox_preserve.Checked & add)
            {
                clearForm();
            }
        }

        private void deleteItemListMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select an item first");
            }
        }
    }

    public class SurplusItem
    {
        public String make;
        public String model;
        public String serial;
        public String type;
        public String hdStatus;
        public String hdSerial;
        public String rcCode;
        public String condCode;
        public Boolean hazard;

        public SurplusItem(String make, String model, String serial, String type)
        {
            this.make = make;
            this.model = model;
            this.serial = serial;
            this.type = type;
        }
        public SurplusItem(String make, String model, String serial, String type, String hdStatus, String hdSerial)
        {
            this.make = make;
            this.model = model;
            this.serial = serial;
            this.type = type;
            this.hdStatus = hdStatus;
            this.hdSerial = hdSerial;
        }
    }
}
