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
            // Boþ bulanýk sistem oluþturuyoruz.
            //
            MamdaniFuzzySystem fsFaiz = new MamdaniFuzzySystem();

            //
            // Sistem için giriþ deðiþkenlerini oluþturuyoruz.
            //
            FuzzyVariable fvKredi = new FuzzyVariable("Kredi", 0.0, 10000.0);
            fvKredi.Terms.Add(new FuzzyTerm("Az", new TrapezoidMembershipFunction(0.0, 0.0, 1000.0, 5000.0)));
            fvKredi.Terms.Add(new FuzzyTerm("Orta", new TrapezoidMembershipFunction(250.0, 4000.0, 6000.0, 9750.0)));
            fvKredi.Terms.Add(new FuzzyTerm("Çok", new TrapezoidMembershipFunction(5000.0, 9000.0, 10000.0, 10000.0)));
            fsFaiz.Input.Add(fvKredi);

            FuzzyVariable fvTaksit = new FuzzyVariable("Taksit", 0.0, 24.0);
            fvTaksit.Terms.Add(new FuzzyTerm("Alt", new TrapezoidMembershipFunction(0.0, 0.0, 1.0, 11.5)));
            fvTaksit.Terms.Add(new FuzzyTerm("Üst", new TrapezoidMembershipFunction(12.5, 23.0, 24.0, 24.0)));
            fsFaiz.Input.Add(fvTaksit);

            //
            // Sistem için çýkýþ deðiþkenini oluþturuyoruz.
            //
            FuzzyVariable fvAFaiz = new FuzzyVariable("AylýkFaiz", 0.0, 150.0);
            fvAFaiz.Terms.Add(new FuzzyTerm("Düþük", new TriangularMembershipFunction(0.0, 25.0, 50.0)));
            fvAFaiz.Terms.Add(new FuzzyTerm("Ort", new TriangularMembershipFunction(50.0, 75.0, 100.0)));
            fvAFaiz.Terms.Add(new FuzzyTerm("Yüksek", new TriangularMembershipFunction(100.0, 125.0, 150.0)));
            fsFaiz.Output.Add(fvAFaiz);

            //
            // Kurallarýmýzý tanýmlýyoruz.
            //
            try
            {
                MamdaniFuzzyRule rule1 = fsFaiz.ParseRule("if (Kredi is Az )  or (Taksit is Alt) then (AylýkFaiz is Düþük)");
                MamdaniFuzzyRule rule2 = fsFaiz.ParseRule("if ((Kredi is Orta)) then (AylýkFaiz is Ort)");
                MamdaniFuzzyRule rule3 = fsFaiz.ParseRule("if (Kredi is Çok) or (Taksit is Üst) then (AylýkFaiz is Yüksek)");

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
            // Yeni bulanýk sistem oluþturuyoruz.
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
            // Deðiþkenleri alýyoruz.
            //
            FuzzyVariable fvKredi = _fsFaiz.InputByName("Kredi");
            FuzzyVariable fvTaksit = _fsFaiz.InputByName("Taksit");
            FuzzyVariable fvAFaiz = _fsFaiz.OutputByName("AylýkFaiz");

            //
            // Giriþ deðerlerini giriþ deðiþkenleriyle iliþkilendiriyoruz.
            //
            int value11 = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int value22 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            Dictionary<FuzzyVariable, double> inputValues = new Dictionary<FuzzyVariable, double>();
            inputValues.Add(fvKredi, value11);
            inputValues.Add(fvTaksit, value22);

            //
            // Sonuç.
            //
            Dictionary<FuzzyVariable, double> result = _fsFaiz.Calculate(inputValues);

            //
            // Çýktý.
            //
            tbFaiz.Text = result[fvAFaiz].ToString("f1");
        }
    }
}
