using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleRudnev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                bool firstTime = true;
                Size = new Size(788, 190);
                void ClearCalculated()
                {
                    foreach (var lbl in panelValues.Controls.OfType<Label>())
                    {
                        lbl.Text = "";
                    }
                }
                void HideValues()
                {
                    if (firstTime)
                    {
                        Size = new Size(788, 470);
                        firstTime = false;
                    }
                }
                btn3Side.Click += (ss, ee) =>
                {
                    HideValues();
                    btn3Side.Enabled = false;
                    panel3Side.Enabled = true;
                    panel1Side.Enabled = false;
                    btn1Side.Enabled = true;
                    btnCalculate.Enabled = true;
                };
                btn1Side.Click += (ss, ee) =>
                {
                    HideValues();
                    btn1Side.Enabled = false;
                    panel1Side.Enabled = true;
                    panel3Side.Enabled = false;
                    btn3Side.Enabled = true;
                    btnCalculate.Enabled = true;
                };
                btnCalculate.Click += (ss, ee) =>
                {
                    if (!btn3Side.Enabled)
                    {
                        if (numericA.Value.ToString().Trim().Length != 0 && numericB.Value.ToString().Trim().Length != 0
                        && numericC.Value.ToString().Trim().Length != 0 && Regex.IsMatch(numericA.Value.ToString(), @"^\d+$") &&
                        Regex.IsMatch(numericB.Value.ToString(), @"^\d+$") && Regex.IsMatch(numericC.Value.ToString(), @"^\d+$"))
                        {
                            Triangle triangle = new Triangle((double)numericA.Value, (double)numericB.Value, (double)numericC.Value);
                            ClearCalculated();
                            lblValues.Text = "Значения";
                            lblValA.Text = "Сторона А:";
                            lblValB.Text = "Сторона B:";
                            lblValC.Text = "Сторона C:";
                            lblValPerimeter.Text = "Периметр:";
                            lblValSemiPerimeter.Text = "Полу периметр:";
                            lblValSurface.Text = "Площадь:";
                            lblValHeight.Text = "Высота:";
                            lblValHeightA.Text = "Высота A:";
                            lblValHeightB.Text = "Высота B:";
                            lblValHeightC.Text = "Высота C:";
                            lblValMedian.Text = "Медиана:";
                            lblValSpecification.Text = "Спецификатор:";
                            lblValExists.Text = "Существует:";
                            lblValuesSideA.Text = triangle.outputA();
                            lblValuesSideB.Text = triangle.outputB();
                            lblValuesSideC.Text = triangle.outputC();
                            lblValuesPerimeter.Text = Convert.ToString(Math.Round(triangle.Perimeter(),3));
                            lblValuesSemiPerimeter.Text = Convert.ToString(Math.Round(triangle.SemiPerimter(),3));
                            lblValuesSurface.Text = Convert.ToString(Math.Round(triangle.Surface(),3));
                            lblValuesHeight.Text =  Convert.ToString(Math.Round(Convert.ToDouble(triangle.outputH()),3));
                            lblValuesHeightA.Text = Convert.ToString(Math.Round(triangle.hA(),3));
                            lblValuesHeightB.Text = Convert.ToString(Math.Round(triangle.hB(), 3));
                            lblValuesHeightC.Text = Convert.ToString(Math.Round(triangle.hC(), 3));
                            lblValuesMedian.Text = Convert.ToString(triangle.Median());
                            lblValuesSpecification.Text = triangle.TriangleType();
                            lblValuesExists.Text = triangle.ExistTriangle ? "Да" : "Нет";
                            panelValues.Size = new Size(745, 330);
                            panelPicture.Location = new Point(9, 770);
                            pictureTriangle.Image = Image.FromFile(triangle.ImageSource());
                            Size = new Size(788, 963);
                        }
                        else
                        {
                            MessageBox.Show("Заполните поля правильно", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MyMethods.WrongValuesNumeric(this, new List<NumericUpDown>() { numericA, numericB, numericC });
                        }
                    }
                    else
                    {
                        if (numericAHeight.Value.ToString().Trim().Length!=0 && numericHeight.Value.ToString().Trim().Length != 0
                        && Regex.IsMatch(numericAHeight.Value.ToString(), @"^\d+$") && Regex.IsMatch(numericAHeight.Value.ToString(), @"^\d+$"))
                        {
                            Triangle triangle = new Triangle((double)numericAHeight.Value, (double)numericAHeight.Value);
                            ClearCalculated();
                            lblValues.Text = "Значения";
                            lblValA.Text = "Сторона А:";
                            lblValB.Text = "Высота:";
                            lblValC.Text = "Площадь:";
                            panelValues.Size = new Size(745, 106);
                            panelPicture.Location = new Point(9, 550);
                            Size = new Size(788, 600);
                            lblValuesSideA.Text = triangle.outputA();
                            lblValuesSideB.Text = triangle.outputH();
                            lblValuesSideC.Text = Convert.ToString(Math.Round(triangle.Side1Surface(),3));
                            pictureTriangle.Image = Image.FromFile(triangle.ImageSource());
                        }
                        else
                        {
                            MessageBox.Show("Заполните поля правильно", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MyMethods.WrongValuesNumeric(this, new List<NumericUpDown>() { numericAHeight, numericHeight });
                        }
                    }
                };
            };
        }
    }
}
