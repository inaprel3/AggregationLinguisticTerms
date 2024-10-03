using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;
using System.Globalization;
using System.Text;

namespace LR1Stasiia
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> termMapping = new Dictionary<string, string>();

        private List<TrapezoidalNumber> trapezoidalNumbers = new List<TrapezoidalNumber>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            float left = float.TryParse(textBoxLeft.Text, out float l) ? l : 0;
            float middle = float.TryParse(textBoxMiddle.Text, out float m) ? m : 0;
            float right = float.TryParse(textBoxRight.Text, out float r) ? r : 0;
            string termName = textBoxTermName.Text.Trim();
            string shortName = textBoxShortName.Text.Trim();

            if (string.IsNullOrWhiteSpace(termName))
            {
                MessageBox.Show("Введіть назву терму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!termMapping.ContainsKey(termName))
            {
                termMapping[termName] = shortName;
            }

            trapezoidalNumbers.Add(new TrapezoidalNumber(termName, shortName, left, middle, right));

            Color[] colors = { Color.Red, Color.Orange, Color.Green, Color.Blue, Color.Purple };

            int triangleCount = zedGraphControl1.GraphPane.CurveList.Count;

            Color color = colors[triangleCount % colors.Length];

            PointPairList trianglePoints = new PointPairList();
            trianglePoints.Add(left, 0);
            trianglePoints.Add(middle, 1);
            trianglePoints.Add(right, 0);

            LineItem triangleCurve = zedGraphControl1.GraphPane.AddCurve(termName, trianglePoints, color, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            string displayText = $"Введені дані: {termName}, {shortName}, {left}, {middle}, {right}";
            listBoxNormalizedIntervals.Items.Add(displayText);
        }

        private void BuildGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();

            foreach (var trapezoidal in trapezoidalNumbers)
            {
                double[] x = new double[] { trapezoidal.Left, trapezoidal.Middle, trapezoidal.Right };
                double[] y = new double[] { 0, 1, 0 };

                zedGraphControl1.GraphPane.AddCurve(trapezoidal.Name, x, y, System.Drawing.Color.Blue);
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            int criteriaCount = int.TryParse(textBoxCriteria.Text.Trim(), out int criteria) ? criteria : 0;
            int alternativesCount = int.TryParse(textBoxAlternatives.Text.Trim(), out int alternatives) ? alternatives : 0;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("", "");

            for (int i = 0; i < criteriaCount; i++)
            {
                dataGridView1.Columns.Add($"Criterion{i + 1}", $"Критерій {i + 1}");
            }

            for (int i = 0; i < alternativesCount; i++)
            {
                dataGridView1.Rows.Add($"Альтернатива {i + 1}");
            }

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Cells[0].Value = "Альтернатива 1";
            }

            if (termMapping.Count == 0)
            {
                MessageBox.Show("Не введено жодного терму!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonNormalize_Click(object sender, EventArgs e)
        {
            if (trapezoidalNumbers.Count == 0)
            {
                MessageBox.Show("Не знайдено жодного трикутного числа для нормалізації!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var trapezoidal in trapezoidalNumbers)
            {
                min = Math.Min(min, trapezoidal.Left);
                min = Math.Min(min, trapezoidal.Middle);
                min = Math.Min(min, trapezoidal.Right);

                max = Math.Max(max, trapezoidal.Left);
                max = Math.Max(max, trapezoidal.Middle);
                max = Math.Max(max, trapezoidal.Right);
            }

            listBoxNormalizedIntervals.Items.Clear();
            for (int i = 0; i < trapezoidalNumbers.Count; i++)
            {
                var trapezoidal = trapezoidalNumbers[i];
                double normalizedLeft = (trapezoidal.Left - min) / (max - min);
                double normalizedMiddle = (trapezoidal.Middle - min) / (max - min);
                double normalizedRight = (trapezoidal.Right - min) / (max - min);

                trapezoidalNumbers[i] = new TrapezoidalNumber(trapezoidal.Name, trapezoidal.ShortName, normalizedLeft, normalizedMiddle, normalizedRight);

                listBoxNormalizedIntervals.Items.Add($"Нормалізовані дані: {trapezoidal.Name}, {trapezoidal.ShortName}, {normalizedLeft}, {normalizedMiddle}, {normalizedRight}");
            }
            BuildGraph();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCriteria.Clear();
            textBoxAlternatives.Clear();
            textBoxTerms.Clear();
            textBoxLeft.Clear();
            textBoxMiddle.Clear();
            textBoxRight.Clear();
            textBoxTermName.Clear();
            textBoxShortName.Clear();
            textBoxAlpha.Clear();

            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.Invalidate();

            listBoxNormalizedIntervals.Items.Clear();
            trapezoidalNumbers.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = string.Empty;
                }
            }
        }

        private void buttonConvertToShortNames_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                {
                    string fullTermName = dataGridView1.Rows[i].Cells[j].Value?.ToString();

                    if (!string.IsNullOrEmpty(fullTermName) && termMapping.ContainsKey(fullTermName))
                    {
                        string shortTermName = termMapping[fullTermName];
                        dataGridView1.Rows[i].Cells[j].Value = shortTermName;
                    }
                    else if (!string.IsNullOrEmpty(fullTermName) && !termMapping.ContainsKey(fullTermName))
                    {
                        MessageBox.Show($"Терм '{fullTermName}' не знайдено.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void buttonConvertToTrapezoidal_Click(object sender, EventArgs e)
        {
            listBoxNormalizedIntervals.Items.Clear();

            HashSet<string> addedTerms = new HashSet<string>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                {
                    string shortTermName = dataGridView1.Rows[i].Cells[j].Value?.ToString();

                    if (!string.IsNullOrEmpty(shortTermName) && termMapping.ContainsValue(shortTermName))
                    {
                        string fullTermName = termMapping.FirstOrDefault(x => x.Value == shortTermName).Key;

                        var trapezoidal = trapezoidalNumbers.FirstOrDefault(t => t.Name == fullTermName);

                        if (trapezoidal != null && !addedTerms.Contains(trapezoidal.Name))
                        {
                            addedTerms.Add(trapezoidal.Name);

                            double trapezoidalLeft = trapezoidal.Left;
                            double trapezoidalMiddle = trapezoidal.Middle;
                            double trapezoidalRight = trapezoidal.Right;

                            string displayText = $"{trapezoidal.Name}, {trapezoidal.ShortName}, {trapezoidalLeft}, {trapezoidalMiddle}, {trapezoidalMiddle}, {trapezoidalRight}";
                            listBoxNormalizedIntervals.Items.Add(displayText);
                        }
                    }
                }
            }
        }

        private double alpha;

        private void buttonTrapezIntervalRatings_Click(object sender, EventArgs e)
        {
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                List<double> leftValues = new List<double>();
                List<double> rightValues = new List<double>();

                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                {
                    string shortTermName = dataGridView1.Rows[i].Cells[j].Value?.ToString();

                    if (!string.IsNullOrEmpty(shortTermName) && termMapping.ContainsValue(shortTermName))
                    {
                        string fullTermName = termMapping.FirstOrDefault(x => x.Value == shortTermName).Key;

                        var trapezoidal = trapezoidalNumbers.FirstOrDefault(t => t.Name == fullTermName);
                        if (trapezoidal != null)
                        {
                            double trapezoidalLeft = trapezoidal.Left;
                            double trapezoidalMiddle = trapezoidal.Middle;
                            double trapezoidalRight = trapezoidal.Right;

                            double newLeft = (alpha * (trapezoidalMiddle - trapezoidalLeft)) + trapezoidalLeft;
                            double newRight = trapezoidalRight - (alpha * (trapezoidalRight - trapezoidalMiddle));

                            leftValues.Add(newLeft);
                            rightValues.Add(newRight);

                            string newCellValue = $"{newLeft:F3}, {newRight:F3}";
                            dataGridView1.Rows[i].Cells[j].Value = newCellValue;
                        }
                    }
                }

                if (leftValues.Count > 0 && rightValues.Count > 0)
                {
                    double minLeft = leftValues.Min();
                    double minRight = rightValues.Min();
                    double pessimisticProbability = CalculateProbability(minLeft, minRight);

                    double maxLeft = leftValues.Max();
                    double maxRight = rightValues.Max();
                    double optimisticProbability = CalculateProbability(maxLeft, maxRight);

                    double avgLeft = leftValues.Average();
                    double avgRight = rightValues.Average();
                    double neutralProbability = CalculateProbability(avgLeft, avgRight);

                    resultBuilder.AppendLine($"Альтернатива {i + 1}:");
                    resultBuilder.AppendLine($"Песимістична позиція: [{minLeft:F3}, {minRight:F3}], Ймовірність: {pessimisticProbability:F3}");
                    resultBuilder.AppendLine($"Оптимістична позиція: [{maxLeft:F3}, {maxRight:F3}], Ймовірність: {optimisticProbability:F3}");
                    resultBuilder.AppendLine($"Нейтральна позиція: [{avgLeft:F3}, {avgRight:F3}], Ймовірність: {neutralProbability:F3}");
                    resultBuilder.AppendLine();
                }
                else
                {
                    resultBuilder.AppendLine($"Альтернатива {i + 1}: немає достатньо даних для розрахунку.");
                }
            }
            MessageBox.Show(resultBuilder.ToString());
        }

        private double CalculateProbability(double left, double right)
        {
            return Math.Max(1 - Math.Max((1 - left) / (right - left + 1), 0), 0);
        }

        private void textBoxAlpha_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAlpha.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double parsedAlpha))
            {
                if (parsedAlpha >= 0 && parsedAlpha <= 1)
                {
                    alpha = parsedAlpha;
                }
                else
                {
                    alpha = 0.5;
                }
            }
            else
            {
                alpha = 0.5;
            }
        }

        private void listBoxNormalizedIntervals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNormalizedIntervals.SelectedItem != null)
            {
                textBoxAlpha.Text = listBoxNormalizedIntervals.SelectedItem.ToString();
            }
        }

        private void buttonSaveAlpha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAlpha.Text))
            {
                MessageBox.Show("Будь ласка, введіть значення альфа.");
                return;
            }

            double alpha;
            if (double.TryParse(textBoxAlpha.Text, out alpha))
            {
                if (alpha < 0 || alpha > 1)
                {
                    MessageBox.Show("Будь ласка, введіть значення альфа в межах від 0 до 1.");
                    return;
                }

                listBoxNormalizedIntervals.Items.Add($"Значення альфа: {alpha}");

                textBoxAlpha.Clear();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректне числове значення для альфа.");
            }
        }

        private void buttonAlphaPositionValue_Click(object sender, EventArgs e)
        {
            labelAlphaValue.Text = $"Значення альфа: {alpha}";
        }
    }
    public class TrapezoidalNumber
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Left { get; set; }
        public double Middle { get; set; }
        public double Right { get; set; }

        public TrapezoidalNumber(string name, string shortName, double left, double middle, double right)
        {
            Name = name;
            ShortName = shortName;
            Left = left;
            Middle = middle;
            Right = right;
        }
    }
}
