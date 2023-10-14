using System.Diagnostics;

namespace _0002SP
{
    public partial class Form1 : Form
    {
        Process?[] processes = { null, null, null, null, null };
        string[] processesNames = { "notepad.exe", "calc.exe", "taskmgr.exe", "cmd.exe", "explorer.exe" };

        int getActiveProcesses()
        {
            int active = 0;

            foreach (Process ?process in processes)
            {
                if (process != null)
                {
                    active++;
                }
            }

            return active;
        }

        int getTextBoxNById(in int id)
        {
            if (textBox1.Text == processesNames[id])
                return 1;
            else if (textBox2.Text == processesNames[id])
                return 2;
            else if (textBox3.Text == processesNames[id])
                return 3;
            else if (textBox4.Text == processesNames[id])
                return 4;
            else if (textBox5.Text == processesNames[id])
                return 5;

            else return -1;
        }

        void textBoxesUp(in int textBoxN)
        {
            switch (textBoxN)
            {
                case 1:
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = textBox3.Text;
                    textBox3.Text = textBox4.Text;
                    textBox4.Text = textBox5.Text;
                    textBox5.Text = string.Empty;
                    break;
                case 2:
                    textBox2.Text = textBox3.Text;
                    textBox3.Text = textBox4.Text;
                    textBox4.Text = textBox5.Text;
                    textBox5.Text = string.Empty;
                    break;
                case 3:
                    textBox3.Text = textBox4.Text;
                    textBox4.Text = textBox5.Text;
                    textBox5.Text = string.Empty;
                    break;
                case 4:
                    textBox4.Text = textBox5.Text;
                    textBox5.Text = string.Empty;
                    break;
                case 5:
                    textBox5.Text = string.Empty;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            int id = comboBox.SelectedIndex;

            try
            {
                if (processes[id] is null)
                {
                    processes[id] = Process.Start(processesNames[id]);

                    switch (getActiveProcesses())
                    {
                        case 1:
                            textBox1.Text = processesNames[id];
                            break;
                        case 2:
                            textBox2.Text = processesNames[id];
                            break;
                        case 3:
                            textBox3.Text = processesNames[id];
                            break;
                        case 4:
                            textBox4.Text = processesNames[id];
                            break;
                        case 5:
                            textBox5.Text = processesNames[id];
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("The process \"" + processesNames[id] + "\" has already started", "Error! (Starting Process)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! (Starting Process)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            int id = comboBox.SelectedIndex;
            int textBoxN = getTextBoxNById(id);

            if (textBoxN != -1)
            {
                processes[id]?.Kill();
                processes[id] = null;

                textBoxesUp(textBoxN);

                MessageBox.Show("Process \"" + processesNames[id] + "\" was closed", "Info (Closing Process)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Process \"" + processesNames[id] + "\" hasn`t started yet", "Error! (Closing Process)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}