﻿using System;
using System.Windows.Forms;

namespace BesedinCoursework
{
    public partial class Top : Form
    {
        private InventorAPI api;
        private Inventor.Application app = null;
        public static double D = 1530, D1 = 1400, T = 40, H = 200, A = 40, ACount = 8; // Основа крышки
        public static double HR = 305, hR = 30, RR = 580, DR = 180, dR = 120, OR = 75, oR = 18, TR = 100; // Резервные проходы
        public static double MBRb = 730, MBRm = 24; // Отверстия под болты
        public static double D1R = 380, d1R = 260, T1R = 240, o1R = 22, O1R = 168, R1R = 540; // Загрузка сыпучих материалов
        public Top()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(D);
            textBox2.Text = Convert.ToString(D1);
            textBox3.Text = Convert.ToString(H);
            textBox4.Text = Convert.ToString(T);
            textBox5.Text = Convert.ToString(A);
            textBox6.Text = Convert.ToString(ACount);
            textBox7.Text = Convert.ToString(MBRb);
            textBox8.Text = Convert.ToString(MBRm);
            textBox9.Text = Convert.ToString(RR);
            textBox10.Text = Convert.ToString(HR);
            textBox11.Text = Convert.ToString(DR);
            textBox12.Text = Convert.ToString(hR);
            textBox13.Text = Convert.ToString(dR);
            textBox14.Text = Convert.ToString(TR);
            textBox15.Text = Convert.ToString(OR);
            textBox16.Text = Convert.ToString(oR);
            textBox17.Text = Convert.ToString(R1R);
            textBox18.Text = Convert.ToString(D1R);
            textBox19.Text = Convert.ToString(d1R);
            textBox20.Text = Convert.ToString(T1R);
            textBox21.Text = Convert.ToString(O1R);
            textBox22.Text = Convert.ToString(o1R);
        }
        private void Build_Click(object sender, EventArgs e)
        {
            app = Auto.appActivity(app);
            if (app == null)
                return;
            api = new InventorAPI(app, "К", "Крышка");
            Build.top(api, Text);
        }
        private void Save_Click(object sender, EventArgs e) =>
            Auto.savePartFunction(app, saveFileDialog1, this, api);
        private void textBox1_TextChanged(object sender, EventArgs e) =>
            D = Auto.checkTextBoxChange(textBox1, 1530);
        private void textBox2_TextChanged(object sender, EventArgs e) =>
            D1 = Auto.checkTextBoxChange(textBox2, 1340);
        private void textBox3_TextChanged(object sender, EventArgs e) =>
            H = Auto.checkTextBoxChange(textBox3, 200);
        private void textBox4_TextChanged(object sender, EventArgs e) =>
            T = Auto.checkTextBoxChange(textBox4, 40);
        private void textBox5_TextChanged(object sender, EventArgs e) =>
            A = Auto.checkTextBoxChange(textBox5, 40);
        private void textBox6_TextChanged(object sender, EventArgs e) =>
            ACount = Auto.checkTextBoxChange(textBox6, 8);
        private void textBox7_TextChanged(object sender, EventArgs e) =>
            MBRb = Auto.checkTextBoxChange(textBox7, 730);
        private void textBox8_TextChanged(object sender, EventArgs e) =>
            MBRm = Auto.checkTextBoxChange(textBox8, 24);
        private void textBox9_TextChanged(object sender, EventArgs e) =>
            RR = Auto.checkTextBoxChange(textBox9, 580);
        private void textBox10_TextChanged(object sender, EventArgs e) =>
            HR = Auto.checkTextBoxChange(textBox10, 305);
        private void textBox11_TextChanged(object sender, EventArgs e) =>
            DR = Auto.checkTextBoxChange(textBox11, 180);
        private void textBox12_TextChanged(object sender, EventArgs e) =>
            hR = Auto.checkTextBoxChange(textBox12, 30);
        private void textBox13_TextChanged(object sender, EventArgs e) =>
            dR = Auto.checkTextBoxChange(textBox13, 120);
        private void textBox14_TextChanged(object sender, EventArgs e) =>
            TR = Auto.checkTextBoxChange(textBox14, 100);
        private void textBox15_TextChanged(object sender, EventArgs e) =>
            OR = Auto.checkTextBoxChange(textBox15, 75);
        private void textBox16_TextChanged(object sender, EventArgs e) =>
            oR = Auto.checkTextBoxChange(textBox16, 18);
        private void textBox17_TextChanged(object sender, EventArgs e) =>
            R1R = Auto.checkTextBoxChange(textBox17, 540);
        private void textBox18_TextChanged(object sender, EventArgs e) =>
            D1R = Auto.checkTextBoxChange(textBox18, 380);
        private void textBox19_TextChanged(object sender, EventArgs e) =>
            d1R = Auto.checkTextBoxChange(textBox19, 260);
        private void textBox20_TextChanged(object sender, EventArgs e) =>
            T1R = Auto.checkTextBoxChange(textBox20, 240);
        private void textBox21_TextChanged(object sender, EventArgs e) =>
            O1R = Auto.checkTextBoxChange(textBox21, 168);
        private void textBox22_TextChanged(object sender, EventArgs e) =>
            o1R = Auto.checkTextBoxChange(textBox22, 22);
    }
}