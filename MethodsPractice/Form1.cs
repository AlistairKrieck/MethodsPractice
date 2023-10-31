using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            /// TODO - Place method calls here

            PrintSignature();
            GetRectArea();
            AddInputs();
            GetCircleArea();
            DisplayLargest();
        }

        /// 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        /// 2. Create a method to calculate the area of a rectangle with
        /// dimensions 5x7, and then use the variables to display:
        /// 
        /// The area of a 5 x 7 rectangle is 35 units squared

        public void GetRectArea()
        {
            int width = 5;
            int length = 7;
            int area = length * width;
            q2Output.Text = $"The area of a rectange of size {length}cm * {width}cm is {area}cm squared";
        }

        /// 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        /// add them together, and then display output as follows:
        /// 
        /// 5 + 4 = 9 
        public void AddInputs()
        {
            try
            {
                double input1 = Convert.ToInt32(q3Num1Input.Text);
                double input2 = Convert.ToInt32(q3Num2Input.Text);
                double answer = input1 + input2;
                q3Output.Text = $"{input1} + {input2} = {answer}";
            }
            catch
            {
                q3Output.Text = "ERROR";
            }

        }


        /// 4. Create a method to calculate the area of a circle based on  
        /// the radius entered in radiusInput, then display output as follows:
        /// 
        /// The area of a circle with radius of 4 is 50.24 units squared

        public void GetCircleArea()
        {
            try
            {
                double radius = Convert.ToInt32(radiusInput.Text);
                double pi = 3.1415;
                double circleArea = pi * radius * radius;
                q4Output.Text = $"Pi * {radius} squared = {circleArea}";
            }
            catch
            {
                q4Output.Text = "ERROR";
            }
        }

        /// 5. 3U Only - Create a method that will determine and display
        /// the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        /// and q5Num3Input. Sample input and output is shown below:
        /// 
        /// Inputs: 5, 7, 2
        /// he largest value is 7
        public void DisplayLargest()
        {
            try
            {
                int input1 = Convert.ToInt32(q5Num1Input.Text);
                int input2 = Convert.ToInt32(q5Num2Input.Text);
                int input3 = Convert.ToInt32(q5Num3Input.Text);

                int[] inputs = { input1, input2, input3 };

                q5Output.Text = $"The largest input is {inputs.Max()}";
            }
            catch
            {
                q5Output.Text = "ERROR";
            }

        }

    }
}
