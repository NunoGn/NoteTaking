﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView.DataSource = table;

            dataGridView.Columns["Message"].Visible = false;
            dataGridView.Columns["Title"].Width = 140;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
