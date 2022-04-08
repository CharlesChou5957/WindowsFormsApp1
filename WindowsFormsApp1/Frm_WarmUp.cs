using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
            this.Text = "Hi";
        }


        private void button_click(object sender, EventArgs e)
        {
            if (sender == btnHello)
            {
                MessageBox.Show("Hello  " + txtName.Text);
            }
            if (sender == btnHi)
            {
                MessageBox.Show("hi  " + txtName.Text);
            }
            if (sender == btnProperty)
            {
                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                btnHello.Visible = false;
            }
            if (sender == btnEnroll) {
               btnTest.Click +=btntest_click;
               btnTest.Click += aaa;
                        }
            if (sender == btnCallForm) {
                frm1 f = new frm1();
                f.Show();
            }
            if (sender == btnStaticInstance) {
                //static property
                MessageBox.Show(SystemInformation.ComputerName);
                //嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
                //   錯誤  CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 其為唯讀 
                //    WindowsFormsApp1    C:\ispan\ado.net\WindowsFormsApp1\WindowsFormsApp1\Form1.cs 48  作用中

                //SystemInformation.ComputerName = "xxxxx";//set property

                string s = SystemInformation.ComputerName;//get property
                //instance
                btnHello.Text = "change";
            }
            if (sender == btnStaticMethod) {
                //static method
                File.Copy("a.txt", "b.txt", true);
                //instance method
                FileInfo f = new FileInfo("b.txt");
                MessageBox.Show(f.FullName + "\n" + f.Extension + "\n" + f.CreationTime);
                f.CopyTo("c.txt",true);
            }
            if (sender == btnFormHello) {
                //frm1 f = new frm1();
                this.Text = "Hello   " + this.txtName.Text;//啟動表單已存在記憶體中
            }
            if (sender == btnClose) {
                this.Close();
            }
          
        } 
          private void  btntest_click(object sender, EventArgs e){
                MessageBox.Show("btntest");

            }
        public void aaa(object sender, EventArgs e) {
            MessageBox.Show("Test Enroll button click");
        }
    
    }
}
