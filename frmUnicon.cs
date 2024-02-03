using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Windows.Forms;

namespace Unicon
{
    public partial class frmUnicon : Form
    {
        string[] ttptext = new string[30];
        List<ObjUnit> obj;
        //public double[,] conv = new double[30,2];
        public double[] mpy = new double[30];
        public double[] offs = new double[30];
        public frmUnicon()
        {
            //this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();
        }

        private void frmUnicon_Load(object sender, EventArgs e)
        {
            string curFile = Properties.Settings.Default.dbFile;
            string path = AppContext.BaseDirectory;
            if (curFile == null || curFile == "units.dat") curFile = path + curFile;
            if (!File.Exists(curFile))
            {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.dbFile = openFileDialog1.FileName;
                    Properties.Settings.Default.Save();
                    curFile = Properties.Settings.Default.dbFile;
                }
                else
                {
                    MessageBox.Show("The Application works only with database file units.dat...Exiting..", "Error");
                    this.Close();
                }
            }
            obj = ReadCsvFile(curFile);
            PopulateComboBox(cmbParam, obj);
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtFrom.Text);
            int f = LBFrom.SelectedIndex;
            int t = LBTo.SelectedIndex;

            if ((f == -1) || (t == -1))
            {
                MessageBox.Show("Please select units from list boxes");
                return;
            }
            double b = (a - offs[f]) / mpy[f] * mpy[t] + offs[t];
            txtTo.Text = b.ToString();
        }

        private void cmbParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListBox(LBFrom, LBTo, cmbParam, obj, ref mpy, ref offs,ref ttptext);
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSwap_Click(object sender, EventArgs e)
        {
            int temp;
            temp = LBFrom.SelectedIndex;
            LBFrom.SelectedIndex = LBTo.SelectedIndex;
            LBTo.SelectedIndex = temp;
        }

        private void LBFrom_MouseMove(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (index >= 0)
                toolTip1.SetToolTip(((ListBox)sender), ttptext[index]);
        }
        //-----------------------------------------------------------------------------------------------
        public class ObjUnit
        {
            public string Param { get; set; }
            public string UnitDescription { get; set; }
            public string Unit { get; set; }
            public double Multiple { get; set; }
            public double Offset { get; set; }
        }

        public static List<ObjUnit> ReadCsvFile(string filePath)
        {
            List<ObjUnit> objects = new List<ObjUnit>();
            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                // Skip the first line (headers)
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');
                    ObjUnit obj = new ObjUnit
                    {
                        Param = fields[0],
                        UnitDescription = fields[1],
                        Unit = fields[2],
                        Multiple = double.Parse(fields[3]),
                        Offset = double.Parse(fields[4])
                    };
                    objects.Add(obj);
                }
            }
            return objects;
        }

        public static void PopulateComboBox(ComboBox comboBox, List<ObjUnit> objects)
        {
            comboBox.Items.Clear();
            comboBox.DisplayMember = "Param";
            comboBox.ValueMember = "Param";
            comboBox.DataSource = objects.Select(x => x.Param).Distinct().ToList();
        }

        public static void PopulateListBox(ListBox listBox1, ListBox listBox2, ComboBox comboBox,
            List<ObjUnit> objects, ref double[] mp, ref double[] ofs,ref string[] ttp1)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string selectedValue = comboBox.SelectedValue.ToString();
            var items = objects.Where(x => x.Param == selectedValue).Select(x => x.Unit);
            listBox1.Items.AddRange(items.ToArray());
            listBox2.Items.AddRange(items.ToArray());
            mp = objects.Where(x => x.Param == selectedValue).Select(x => x.Multiple).ToArray();
            ofs = objects.Where(x => x.Param == selectedValue).Select(x => x.Offset).ToArray();
            ttp1= objects.Where(x => x.Param == selectedValue).Select(x => x.UnitDescription).ToArray();
        }

    }
}
