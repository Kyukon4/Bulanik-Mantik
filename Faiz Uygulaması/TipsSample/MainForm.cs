using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AI.Fuzzy.Library;

namespace AI.Fuzzy.Samples.TipsSample
{
    public partial class MainForm : Form
    {
        MamdaniFuzzySystem _fsFaiz = null;

        public MainForm()
        {
            InitializeComponent();
        }

        MamdaniFuzzySystem CreateSystem()
        {
            //
            // Bo� bulan�k sistem olu�turuyoruz.
            //
            MamdaniFuzzySystem fsFaiz = new MamdaniFuzzySystem();

            //
            // Sistem i�in giri� de�i�kenlerini olu�turuyoruz.
            //
            FuzzyVariable fvKredi = new FuzzyVariable("Kredi", 0.0, 10000.0);
            fvKredi.Terms.Add(new FuzzyTerm("Az", new TrapezoidMembershipFunction(0.0, 0.0, 1000.0, 5000.0)));
            fvKredi.Terms.Add(new FuzzyTerm("Orta", new TrapezoidMembershipFunction(250.0, 4000.0, 6000.0, 9750.0)));
            fvKredi.Terms.Add(new FuzzyTerm("�ok", new TrapezoidMembershipFunction(5000.0, 9000.0, 10000.0, 10000.0)));
            fsFaiz.Input.Add(fvKredi);

            FuzzyVariable fvTaksit = new FuzzyVariable("Taksit", 0.0, 24.0);
            fvTaksit.Terms.Add(new FuzzyTerm("Alt", new TrapezoidMembershipFunction(0.0, 0.0, 1.0, 11.5)));
            fvTaksit.Terms.Add(new FuzzyTerm("�st", new TrapezoidMembershipFunction(12.5, 23.0, 24.0, 24.0)));
            fsFaiz.Input.Add(fvTaksit);

            //
            // Sistem i�in ��k�� de�i�kenini olu�turuyoruz.
            //
            FuzzyVariable fvAFaiz = new FuzzyVariable("Ayl�kFaiz", 0.0, 150.0);
            fvAFaiz.Terms.Add(new FuzzyTerm("D���k", new TriangularMembershipFunction(0.0, 25.0, 50.0)));
            fvAFaiz.Terms.Add(new FuzzyTerm("Ort", new TriangularMembershipFunction(50.0, 75.0, 100.0)));
            fvAFaiz.Terms.Add(new FuzzyTerm("Y�ksek", new TriangularMembershipFunction(100.0, 125.0, 150.0)));
            fsFaiz.Output.Add(fvAFaiz);

            //
            // Kurallar�m�z� tan�ml�yoruz.
            //
            try
            {
                MamdaniFuzzyRule rule1 = fsFaiz.ParseRule("if (Kredi is Az )  or (Taksit is Alt) then (Ayl�kFaiz is D���k)");
                MamdaniFuzzyRule rule2 = fsFaiz.ParseRule("if ((Kredi is Orta)) then (Ayl�kFaiz is Ort)");
                MamdaniFuzzyRule rule3 = fsFaiz.ParseRule("if (Kredi is �ok) or (Taksit is �st) then (Ayl�kFaiz is Y�ksek)");

                fsFaiz.Rules.Add(rule1);
                fsFaiz.Rules.Add(rule2);
                fsFaiz.Rules.Add(rule3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Parsing exception: {0}", ex.Message));
                return null;
            }

            return fsFaiz;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //
            // Yeni bulan�k sistem olu�turuyoruz.
            //
            if (_fsFaiz == null)
            {
                _fsFaiz = CreateSystem();
                if (_fsFaiz == null)
                {
                    return;
                }
            }

            //
            // De�i�kenleri al�yoruz.
            //
            FuzzyVariable fvKredi = _fsFaiz.InputByName("Kredi");
            FuzzyVariable fvTaksit = _fsFaiz.InputByName("Taksit");
            FuzzyVariable fvAFaiz = _fsFaiz.OutputByName("Ayl�kFaiz");

            //
            // Giri� de�erlerini giri� de�i�kenleriyle ili�kilendiriyoruz.
            //
            int value11 = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int value22 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            Dictionary<FuzzyVariable, double> inputValues = new Dictionary<FuzzyVariable, double>();
            inputValues.Add(fvKredi, value11);
            inputValues.Add(fvTaksit, value22);

            //
            // Sonu�.
            //
            Dictionary<FuzzyVariable, double> result = _fsFaiz.Calculate(inputValues);

            //
            // ��kt�.
            //
            tbFaiz.Text = result[fvAFaiz].ToString("f1");
        }
    }
}
