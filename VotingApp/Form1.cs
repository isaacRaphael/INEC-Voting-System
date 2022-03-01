using Core.Contracts;
using Core.DTOs;
using Models.Enums;
using Core.Services;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class Form1 : Form { 


        private readonly IRegistrationService _registrationService;
        private readonly Database _database;
        public Form1(IRegistrationService registrationService, Database database)
        {
            InitializeComponent();
            _registrationService = registrationService;
            _database = database;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var details = new VoterRegDTO()
            {
                FirstName = FirstName_textBox.Text,
                MiddleName = MiddleName_textBox.Text,
                LastName = LastName_textBox.Text,
                DateOfBirth = dateTimePicker1.Text,
                Gender = MaleradioButton.Checked == true ? Gender.Male : FemaleradioButton.Checked == true ? Gender.Female : Gender.Other
                 
            };
            ClearLoginField();
            _registrationService.RegisterNewVoter(details);
            MessageBox.Show("Voter Added");   
        }
        public void ClearLoginField()
        {
            MiddleName_textBox.Text = "";
            FirstName_textBox.Text = "";
            LastName_textBox.Text = "";
            profpic_path_textbox.Text = "";
            ProfilePicture.ImageLocation = "";
        }
        private void View_List_Label_Click(object sender, EventArgs e)
        {
            var Window2 = new VoterTable(_database);
            Window2.Show();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
           
        }
        private void FemaleradioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void PollingUnit_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_ProfPic_Btn_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ProfilePicture.ImageLocation = imagePath;
                    profpic_path_textbox.Text = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
