using MyDLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
	/// <summary>
	/// A Basic Calculator
	/// </summary>
	public partial class MyFirstForm : Form
    {
        public int MyVar { get; set; }
        private double val = 0;
        private double memory = 0;
        private double finalValue = 0;
        private bool hasPoint = false;

        private MyEnums myLastAction = MyEnums.None;

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MyFirstForm()
        {
            InitializeComponent();
        }
        #endregion


        #region Operator Methods

        private void PercentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new AccessViolationException();

				val = Convert.ToDouble(UserInputText.Text);
                val /= 100;
                UserInputText.Text = Convert.ToString(val);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 101");
                Logger.LogError(ex.Message);
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoAction();
                val = Convert.ToDouble(UserInputText.Text);
                UserInputText.Text = "";
                hasPoint = false;
                if (myLastAction == MyEnums.None)
                {
                    finalValue = val;
                }
                myLastAction = MyEnums.Divide;
                operation.Text = $"{finalValue}÷";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 102");
                Logger.LogError(ex);
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoAction();
                val = Convert.ToDouble(UserInputText.Text);
                UserInputText.Text = "0";
                hasPoint = false;
                if (myLastAction == MyEnums.None)
                {
                    finalValue = val;
                }
                myLastAction = MyEnums.Multiply;
                operation.Text = $"{finalValue}x";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 103");
                Logger.LogError(ex);
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoAction();
                val = Convert.ToDouble(UserInputText.Text);
                UserInputText.Text = "0";
                hasPoint = false;
                if (myLastAction == MyEnums.None)
                {
                    finalValue = val;
                }
                myLastAction = MyEnums.Minus;
                operation.Text = $"{finalValue}-";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 104");
                Logger.LogError(ex);
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoAction();
                val = Convert.ToDouble(UserInputText.Text);
                UserInputText.Text = "0";
                hasPoint = false;
                if (myLastAction == MyEnums.None)
                {
                    finalValue = val;
                }
                myLastAction = MyEnums.Plus;
                operation.Text = $"{finalValue}+";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 105");
                Logger.LogError(ex);
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoAction();
                myLastAction = MyEnums.None;
                hasPoint = false;
                UserInputText.Text = $"{finalValue}";
                if (!operation.Text.Contains('='))
                {
                    operation.Text += $"{val}=";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 106");
                Logger.LogError(ex);
            }
        }
        #endregion
        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
                if (UserInputText.Text.Length > 1)
                {
                    UserInputText.Text = UserInputText.Text.Substring(0, UserInputText.Text.Length - 1);
                }
                else
                    UserInputText.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 107");
                Logger.LogError(ex);
            }
        }
        private void CEButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserInputText.Text = "";
                hasPoint = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 108");
                Logger.LogError(ex);
            }
        }
        private void CButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserInputText.Text = "";
                val = 0;
                finalValue = 0;
                hasPoint = false;
                myLastAction = MyEnums.None;
                operation.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 109");
                Logger.LogError(ex);
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            try
            {
                string tag = ((Button)sender).Tag.ToString();
                if (UserInputText.Text == "0")
                {
                    UserInputText.Text = "";
                }
                UserInputText.Text += tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 110");
                Logger.LogError(ex);
            }
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hasPoint)
                {
                    UserInputText.Text += ".";
                    hasPoint = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 111");
                Logger.LogError(ex);
            }
        }
        private void DoAction()
        {
            try
            {
                if (myLastAction == MyEnums.Plus)
                {
                    val = Convert.ToDouble(UserInputText.Text);
                    finalValue += val;
                    val = finalValue;
                }

                if (myLastAction == MyEnums.Minus)
                {
                    val = Convert.ToDouble(UserInputText.Text);
                    finalValue -= val;

                }

                if (myLastAction == MyEnums.Multiply)
                {
                    val = Convert.ToDouble(UserInputText.Text);
                    finalValue *= val;
                }

                if (myLastAction == MyEnums.Divide)
                {
                    val = Convert.ToDouble(UserInputText.Text);

                    if (myLastAction == MyEnums.None)
                    {
                        finalValue = val;
                    }
                    else
                    {
						if (val == 0)
						{
                            MessageBox.Show("Can't divide by 0");
						}
						else
						{
                            finalValue /= val;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 112");
                Logger.LogError(ex);
            }
        }

        private void Mrecall_Click(object sender, EventArgs e)
        {
            try
            {
                UserInputText.Text = $"{memory}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 113");
                Logger.LogError(ex);
            }
        }

        private void Mclear_Click(object sender, EventArgs e)
        {
            try
            {
                memory = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 114");
                Logger.LogError(ex);
            }
        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            try
            {
                memory += Convert.ToDouble(UserInputText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 115");
                Logger.LogError(ex);
            }
        }

        private void Mminus_Click(object sender, EventArgs e)
        {
            try
            {
                memory -= Convert.ToDouble(UserInputText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 116");
                Logger.LogError(ex);
            }
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var negSwitch = Convert.ToDouble(UserInputText.Text);
                negSwitch = -negSwitch;
                UserInputText.Text = Convert.ToString(negSwitch);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare. Contactează adminul", "Eroare 117");
                Logger.LogError(ex);
            }
        }
    }

}