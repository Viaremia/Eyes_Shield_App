using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h_Timer_2
{
    public partial class Form1 : Form
    {
        int timeCounter = 0;
        Form2 msg = new Form2();

        public Form1()
        {
            InitializeComponent();
            button_start.Click += Button_start_Click;
            button_hide.Click += Button_hide_Click;
            notifyIcon.Click += NotifyIcon_Click;
            button_close.Click += Button_close_Click;
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeCounter == 0)
            {
                this.Hide();
                msg.Show();
                notifyIcon.Visible = false;
            }
            else
            {
                timeCounter--;
                textBox_output.Text = (timeCounter).ToString();
            }
                
        }

        //кнопка завершения работы с формой
        private void Button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //кнопка открытия формы из трея
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
        }
        
        //кнопка сокрытия формы
        private void Button_hide_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            this.Hide();
        }
        
        //старт таймера
        private void Button_start_Click(object sender, EventArgs e)
        {
            timeCounter = Convert.ToInt32(textBox_input.Text);
            textBox_output.Text = (timeCounter).ToString();
            timer.Start();
            timeCounter--;
        }
    }
}
