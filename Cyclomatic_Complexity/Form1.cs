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

namespace Cyclomatic_Complexity
{
    
    public partial class Form1 : Form
    {   
       
        public Form1()
        {
            InitializeComponent();
        }
        
       
        public int CountKeyword(string code,string keyword) //Counts keywords that increase cyclomatic complexity in the code.
        {
            int keycount = 0;
            foreach (Match m in Regex.Matches(code,keyword, RegexOptions.IgnoreCase))
            {                       
                keycount++;            
            }  
            return keycount;
        }

       public string ClearCodeLine(string[] codeLinebyLine) //Clears comments, print and input lines in the code-
        {                                                   //-to accurately measure cyclomatic complexity.
            int i;
            for(i=0 ; i<codeLinebyLine.Length ; i++)
            {
               if(codeLinebyLine[i].Contains("#"))
                {                 
                    codeLinebyLine[i] = "";               
                }

               else if (codeLinebyLine[i].Contains("input(") || codeLinebyLine[i].Contains("print("))
                {
                    
                    while (!codeLinebyLine[i].Contains(")"))
                    {
                        codeLinebyLine[i] = "";
                        i++;                      
                    }
                    codeLinebyLine[i] = "";
                }

            }
            string code = string.Join("",codeLinebyLine);
            return code;
        }

        public int CalculateCyclomaticComplexity() //Calculates cyclomatic complexity of incoming cleaned code.
        {
            int cyclomaticComplexity = 0;
            string[] codeLinebyLine = textBoxCode.Lines;
            string code = ClearCodeLine(codeLinebyLine);

            cyclomaticComplexity = CountKeyword(code,"def") + CountKeyword(code,"for") 
                   + CountKeyword(code,"while") + CountKeyword(code, "if")
                   + CountKeyword(code, " and ") + CountKeyword(code, " or ");

            return cyclomaticComplexity;
        }
        public void ShowRisk(int cyclomaticComplexity) //Gives information about the risk of the code-
        {                                              //-according to the cyclomatic complex of the code.
            if (cyclomaticComplexity <= 10) 
            {   
                labelRisk.Text = "A simple code that is not too risky";
            }
            else if (cyclomaticComplexity > 10 && cyclomaticComplexity <= 20)
            {
                labelRisk.Text = "Slightly more complex code with medium risk";
            }
            else if (cyclomaticComplexity > 20 && cyclomaticComplexity <= 40)
            {
                labelRisk.Text = "A high-risk complex code";
            }
            else
            {
                labelRisk.Text = "A very risky untestable code";
            }
        }  

        private void button1_Click(object sender, EventArgs e) //Shows cyclomatic complexity.
        {           
            labelResult.Text = "Cyclomatic Complexity : " + CalculateCyclomaticComplexity();            
        }
        
        private void button2_Click(object sender, EventArgs e) //Shows risk level.
        {
            ShowRisk(CalculateCyclomaticComplexity());
        }

    }
}
