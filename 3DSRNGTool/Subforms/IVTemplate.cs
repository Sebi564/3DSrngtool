﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pk3DSRNGTool
{
    public partial class IVTemplate : Form
    {
        public MainForm parentform => Program.mainform;
        private bool _EggParents { get; set; }
        public IVTemplate(bool EggParents = true)
        {
            InitializeComponent();

            _EggParents = EggParents;

            if (!EggParents)
            {
                B_Male.Text = "Set low IV";
                B_Female.Text = "Set high IV";
            }

            string txt = Properties.Settings.Default.Ivspread;
            if (txt == "")
            {
                IVSpread.Items.Add("Perfect = 31,31,31,31,31,31");
                IVSpread.Items.Add("6Zero = 0,0,0,0,0,0");
                IVSpread.Items.Add("HPIce = 31,0,30,31,31,31");
                IVSpread.Items.Add("HPFire = 31,0,31,30,31,30");
                IVSpread.Items.Add("Physical = 31,31,31,0,31,31");
                IVSpread.Items.Add("Special = 31,0,31,31,31,31");
                IVSpread.Items.Add("Trick Room = 31,31,31,31,31,0");
                IVSpread.Items.Add("TR. Phy. = 31,31,31,0,31,0");
                IVSpread.Items.Add("TR. Spe. = 31,0,31,31,31,0");
                return;
            }
            string[] Ivspreadlist = txt.Split(';');
            foreach (var IV in Ivspreadlist)
                if (parseSTR(IV) != null)
                    IVSpread.Items.Add(IV);
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            if (parseSTR(InputBox.Text) != null)
            {
                IVSpread.Items.Add(InputBox.Text);
                InputBox.Text = "";
            }
        }

        private int[] parseSTR(string text)
        {
            try
            {
                string[] SplitString = text.Split(new[] { " = " }, StringSplitOptions.None);
                string[] ivstr = SplitString[1].Split(',', ' ');
                int[] ivs = ivstr.Select(str => Convert.ToInt32(str)).ToArray();
                if (ivs.Length == 6 && ivs.All(iv => 0 <= iv && iv <= 31))
                    return ivs;
                return null;
            }
            catch
            {
                return null;
            }
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            IVSpread.Items.RemoveAt(IVSpread.SelectedIndex >= 0 ? IVSpread.SelectedIndex : IVSpread.Items.Count - 1);
        }

        private void B_Male_Click(object sender, EventArgs e)
        {
            if (IVSpread.SelectedIndex >= 0)
            {
                if (_EggParents) { parentform.IV_Male = parseSTR(IVSpread.Items[IVSpread.SelectedIndex].ToString()); }
                else { parentform.IVlow = parseSTR(IVSpread.Items[IVSpread.SelectedIndex].ToString()); }
            }
        }

        private void B_Female_Click(object sender, EventArgs e)
        {
            if (IVSpread.SelectedIndex >= 0)
            {
                if (_EggParents) { parentform.IV_Female = parseSTR(IVSpread.Items[IVSpread.SelectedIndex].ToString()); }
                else { parentform.IVup = parseSTR(IVSpread.Items[IVSpread.SelectedIndex].ToString()); }
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            string output = "";
            for (int i = 0; i < IVSpread.Items.Count; i++)
                output += IVSpread.Items[i].ToString() + ";";
            Properties.Settings.Default.Ivspread = output;
            Properties.Settings.Default.Save();
            MessageBox.Show("Templates saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
