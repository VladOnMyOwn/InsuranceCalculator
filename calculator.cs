using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace insurance_calculator {
    public partial class Calculator : Form {
        public Calculator() {
            InitializeComponent();
            
            summ.ReadOnly = true;
            
            foreach (var m in model_source) {
                auto.Items.Add(m);
            }

            sex_choose.ForeColor = Color.White;
            insur_type.ForeColor = Color.White;

            // auto.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void d_exp_KeyPress(object sender, KeyPressEventArgs e) {
            var number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) {
                e.Handled = true;
            }
        }

        private readonly List<string> model_source = new() {
            "Chevrolet NIVA", "Datsun on-DO", "Hyundai Creta", "Hyundai Solaris", "KIA Rio", "KIA Sportage", "Lada 4x4",
            "Lada Granta", "Lada Kalina", "Lada Largus", "Lada Vesta", "Lada X-Ray", "Mazda CX-5", "Nissan Qashqai",
            "Nissan X-Trail", "Renault Duster", "Renault Kaptur", "Renault Logan", "Renault Sandero",
            "Skoda Octavia A7", "Skoda Rapid", "Toyota Camry", "Toyota RAV 4", "VW Polo", "VW Tiguan"
        };

        private int sex;
        private string exp;
        private int model;
        private int tinsur;
        private string t;
        
        private void calc_Click(object sender, EventArgs e) {
            
            sex = sex_female.Checked switch {
                true => 0,
                _ => 1
            };

            int _exp;
            try {
                _exp = Convert.ToInt32(d_exp.Text);
            }
            catch (Exception exception) {
                MessageBox.Show("Стаж вождения указан некорректно!");
                throw new ArgumentException();
            }
            if (_exp is >= 0 and <= 9){
                exp = "0-9";
            }
            else{
                if (_exp is >= 10 and <= 19){
                    exp = "10-19";
                }
                else{
                    if (_exp is >= 20 and <= 29){
                        exp = "20-29";
                    }
                    else{
                        if (_exp is >= 30 and <= 85)
                            exp = "30-70";
                        else
                        {
                            MessageBox.Show("Стаж вождения указан некорректно!");
                            throw new ArgumentException();
                        }
                    }
                }
            }

            var econom = new List<string>() {"lada 4x4", "lada granta", "datsun on-do", "hyundai solaris", "renault logan", "lada x-ray", "chevrolet niva", "lada largus", "lada kalina"};
            var middle = new List<string>() {"renault duster", "kia rio", "vw polo", "lada vesta", "skoda rapid", "skoda octavia a7", "renault sandero"};
            var business = new List<string>() {"toyota camry", "hyundai creta", "kia sportage", "vw tiguan", "toyota rav 4", "renault kaptur", "nissan qashqai", "nissan x-trail", "mazda cx-5"};
            if (econom.Contains(auto.Text.ToLower())) {
                model = 0;
            }
            else {
                if (middle.Contains(auto.Text.ToLower())) {
                    model = 1;
                }
                else {
                    if (business.Contains(auto.Text.ToLower())) {
                        model = 2;
                    }
                    else {
                        MessageBox.Show("Введено некорректное название марки автомобиля!");
                        throw new ArgumentException();
                    }
                }
            }

            tinsur = full.Checked switch {
                true => 0,
                _ => 1
            };

            var psi = new ProcessStartInfo {
                // var script = @".\pythonscript\strakhovanie_tr.py";
                // psi.FileName = @"D:\Programs\Python\python.exe";
                FileName = @".\pythonscript\strakhovanie_tr.exe",
                Arguments = $"{null} {sex} {exp} {model} {tinsur}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var errors = "";
            var results = "";
            using(var process = Process.Start(psi)) {
                if (process != null) {
                    errors = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
            }
            
            t = results;
            
            summ.ReadOnly = false;
            summ.Text = t + " ₽";
            summ.ReadOnly = true;
        }
        
    }
}