using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MessageBoxLab
{
    public partial class Form1 : Form
    {
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        MessageBoxIcon icon = MessageBoxIcon.Warning;
        MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;
        MessageBoxOptions options = MessageBoxOptions.RightAlign;

        string title = string.Empty;
        public Form1()
        {
            InitializeComponent();
            labelUserChoice.Text = 
                "Выбор пользователя";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Now.ToString("HH:mm:ss");
            Text = $"Старт в {dt}";
        }

        private void btnOneB_MouseClick(object sender, MouseEventArgs e)
        {
            var text = "Одна кнопка";
            var caption = "Заголовок однокнопочного окна";
            
            
            if (rbOK.Checked)
            {
                buttons = MessageBoxButtons.OK;
            }
            
            var result =
            MessageBox.Show(text, // сообщение
                caption, // заголовок
                buttons, // кнопки
                icon,   // иконка
                defaultButton); // кнопка по умолчанию
                //options); // справа налево
            labelUserChoice.Text = result.ToString();
            if (result == DialogResult.OK)
            {
                this.BackColor = Color.BlueViolet;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelInfo.Text = 
                DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void btnTwoB_MouseHover(object sender, EventArgs e)
        {
            this.title = Text;
            Text = btnTwoB.Text;
            //Text += " " + sender.ToString();
            var tmp = (Button)sender;
            var size = tmp.Size;
            var location = tmp.Location;
            Text += " " + $"ширина {size.Width}" +
                $" высота {size.Height} " +
                $"координты " +
                $"({location.X}, {location.Y})";
        }

        private void btnTwoB_MouseLeave(object sender, EventArgs e)
        {
            Text = title;
        }

        private void btnTwoB_MouseClick(object sender, MouseEventArgs e)
        {
            var text = "Две кнопки";
            var caption = "Заголовок Двукнопочного окна";
            
            
            if (rbOkCancel.Checked)
            {
                buttons = MessageBoxButtons.OKCancel;
            }
            else if (rbRetryCancel.Checked)
            {
                buttons = MessageBoxButtons.RetryCancel;
            }
            else if (rbYesNo.Checked)
            {
                buttons = MessageBoxButtons.YesNo;
            }
            var result =
           MessageBox.Show(text, // сообщение
               caption, // заголовок
               buttons, // кнопки
               icon,   // иконка
               defaultButton); // кнопка по умолчанию
                               //options); // справа налево
            labelUserChoice.Text = result.ToString();
            if (result == DialogResult.OK)
            {
                this.BackColor = Color.BlueViolet;
            }
            
        }

        private void rbOkCancel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThreeB_Click(object sender, EventArgs e)
        {
            var text = "Три кнопки";
            var caption = "Заголовок трехкнопочного окна";
           
            if (rbYesNoCancel.Checked)
            {
                buttons = MessageBoxButtons.YesNoCancel;
            }
            
            else if (rbAbortRetryIgnore.Checked)
            {
                buttons = MessageBoxButtons.AbortRetryIgnore;
            }
            
            var result =
           MessageBox.Show(text, // сообщение
               caption, // заголовок
               buttons, // кнопки
               icon,   // иконка
               defaultButton); // кнопка по умолчанию
                               //options); // справа налево
            labelUserChoice.Text = result.ToString();
            if (result == DialogResult.OK)
            {
                this.BackColor = Color.BlueViolet;
            }
        }

        private void listBoxIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Warning;
            if (listBoxIcon.Text == "Asterisk")
            {
                icon = MessageBoxIcon.Asterisk;
            }
            else if (listBoxIcon.Text == "Error")
            {
                icon = MessageBoxIcon.Error;
            }
            else if (listBoxIcon.Text == "Exclamation")
            {
                icon = MessageBoxIcon.Exclamation;
            }
            else if (listBoxIcon.Text == "Hand")
            {
                icon = MessageBoxIcon.Hand;
            }
            else if (listBoxIcon.Text == "Information")
            {
                icon = MessageBoxIcon.Information;
            }
            else if (listBoxIcon.Text == "None")
            {
                icon = MessageBoxIcon.None;
            }
            else if (listBoxIcon.Text == "Question")
            {
                icon = MessageBoxIcon.Question;
            }
            else if (listBoxIcon.Text == "Stop")
            {
                icon = MessageBoxIcon.Stop;
            }
            else if (listBoxIcon.Text == "Warning")
            {
                icon = MessageBoxIcon.Warning;
            }
        }
    }
}
