using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // sync
        {
            richTextBox1.Clear();

            var totalNum = 0;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500); // 0.5초

                richTextBox1.AppendText("....\n");
                totalNum++;
            }

            richTextBox1.AppendText("\nresult = " + totalNum);
            richTextBox1.AppendText("\nFINISH");
        }

        private void button2_Click(object sender, EventArgs e) // async
        {
            var uiThread = TaskScheduler.FromCurrentSynchronizationContext();

            richTextBox1.Clear();

            Task.Factory.StartNew(() => // 비동기로 작업을 시작
            {
                var totalNum = 0;

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500); // 0.5초

                    richTextBox1.BeginInvoke(new Action(() => richTextBox1.AppendText("....\n")));
                    totalNum++;
                }

                return totalNum;
            }).ContinueWith(x => // 비동기로 위의 작업을 하고
            {
                richTextBox1.AppendText("\nresult = " +x.Result); // 위의 작업을 끝났을 때 이 작업을 실행
            }, uiThread);

            richTextBox1.AppendText("\nFINISH");
            // 비동기 작업은 동기작업과 다르게 FINISH가 먼저찍히고 작업이 수행된다.
            
        }

    }
}
