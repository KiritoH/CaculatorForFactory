using com.yww.doubleOperator;
using com.yww.doubleOperatorFactory;

using com.yww.singleOperator;
using com.yww.singleOperatorFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.yww.fe
{
    public partial class Form1 : Form
    {
        
        //用于记录第一个操作数
        String operator_num1 = "";
        //用于记录第二个操作数
        String operator_num2 = "";
        //确定当前有没有输入运算符
        bool operatorStatus = false;
        //记录当前操作符
        DoubleOperator operator_pre ;
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = System.Environment.CurrentDirectory + "/Skins/MacOS.ssk";

        }

        //数字0
        private void button_0_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true) {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "0";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }else {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        
        }
        //数字1
        private void button_1_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "1";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }

        //数字2
        private void button_2_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "2";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //数字3
        private void button_3_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "3";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //数字4
        private void button_4_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "4";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //数字5
        private void button_5_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "5";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //数字6
        private void button_6_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "6";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }

        //数字7
        private void button_7_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "7";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //数字8
        private void button_8_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "8";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //数字9
        private void button_9_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "";
                operatorStatus = false;
            }
            textBox1.Text += "9";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }

        //点
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (operatorStatus == true)
            {
                textBox1.Text = "0.";
                operatorStatus = false;
                //判断现在是对操作数一进行操作还是操作数二进行操作
                if (operator_pre == null)
                {
                    //第一个操作数赋值
                    operator_num1 = textBox1.Text;
                }
                else
                {
                    //否则第二个操作数赋值
                    operator_num2 = textBox1.Text;
                }
                return;
            }
            //要判断有没有"."
            if (-1 != textBox1.Text.IndexOf(".")) {
                //有"."
                return ;
            }
            textBox1.Text += ".";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }

        //退位符
        private void button_back_Click(object sender, EventArgs e)
        {
            //先看有没有
            if (textBox1.Text == "") {
                return;
            }
            //有便退位
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }

        //清空当前输入
        private void button_CE_Click(object sender, EventArgs e)
        {
            //先看有没有
            if (textBox1.Text == "")
            {
                return;
            }
            //有便消除
            textBox1.Text = "";
            //判断现在是对操作数一进行操作还是操作数二进行操作
            if (operator_pre == null)
            {
                //第一个操作数赋值
                operator_num1 = textBox1.Text;
            }
            else
            {
                //否则第二个操作数赋值
                operator_num2 = textBox1.Text;
            }
        }
        //取消此次计算
        private void button_C_Click(object sender, EventArgs e)
        {
            operatorStatus = false;
            operator_pre = null;
            operator_num1 = "";
            operator_num2 = "";
            textBox1.Clear();
        }
        //求相反数
        private void button_opp_Click(object sender, EventArgs e)
        {
            //三种情况
            //没有操作值
            if (operator_num1 == "")
            {
                return;  
            }
            //第一个操作值
            if (operator_num1 != "" && operator_num2 == "")
            {
                SingleOperator singleOperator = new TakeOppositeNumberOperatorFactory().GetOperator();
                operator_num1 = "" + singleOperator.operate(System.Convert.ToDouble(operator_num1));
                textBox1.Text = operator_num1;
                return;
            }
            //第二个操作值
            if (operator_num1 != "" && operator_num2 != "")
            {
                SingleOperator singleOperator = new TakeOppositeNumberOperatorFactory().GetOperator();
                operator_num2 = "" + singleOperator.operate(System.Convert.ToDouble(operator_num2));
                textBox1.Text = operator_num2;
                return;
            }
        }

        //开根号
        private void button_squ_Click(object sender, EventArgs e)
        {
            //三种情况
            //没有操作值
            if (operator_num1 == "")
            {
                return;
            }
            //第一个操作值
            if (operator_num1 != "" && operator_num2 == "")
            {
                SingleOperator singleOperator = new SquareRootOperatorFactory().GetOperator();
                operator_num1 = ""+singleOperator.operate(System.Convert.ToDouble(operator_num1));
                textBox1.Text = operator_num1;
                return;
            }
            //第二个操作值
            if (operator_num1 != "" && operator_num2 != "")
            {
                SingleOperator singleOperator = new SquareRootOperatorFactory().GetOperator();
                operator_num2 = "" + singleOperator.operate(System.Convert.ToDouble(operator_num2));
                textBox1.Text = operator_num2;
                return;
            }
        }
        //除法运算
        private void button_div_Click(object sender, EventArgs e)
        {
            //三种情况
            //第一种：第一个操作数还没有值，也没有进行运算
            if (operator_num1 == "")
            {
                return;
            }
            //第二种：此时第一个操作数有值了
            if (operator_num1 != "" && operator_num2 == "")
            {
                operator_pre = new DivisionOperatorFactory().GetOperator();
                operatorStatus = true;
                return;
            }
            //第三种：此时第一个第二个操作数都有值，运算符也存在
            if (operator_num1 != "" && operator_num2 != "")
            {
                //先进行运算
                double result = operator_pre.operate(System.Convert.ToDouble(operator_num1), System.Convert.ToDouble(operator_num2));
                //然后进行设置
                operator_pre = new DivisionOperatorFactory().GetOperator();
                operator_num1 = result.ToString();
                textBox1.Text = operator_num1;
                operator_num2 = "";
                operatorStatus = true;
                return;
            }
        }
        //乘法运算
        private void button_mul_Click(object sender, EventArgs e)
        {
            //三种情况
            //第一种：第一个操作数还没有值，也没有进行运算
            if (operator_num1 == "")
            {
                return;
            }
            //第二种：此时第一个操作数有值了
            if (operator_num1 != "" && operator_num2 == "")
            {
                operator_pre = new MutiplicationOperatorFactory().GetOperator();
                operatorStatus = true;
                return;
            }
            //第三种：此时第一个第二个操作数都有值，运算符也存在
            if (operator_num1 != "" && operator_num2 != "")
            {
                //先进行运算
                double result = operator_pre.operate(System.Convert.ToDouble(operator_num1), System.Convert.ToDouble(operator_num2));
                //然后进行设置
                operator_pre = new MutiplicationOperatorFactory().GetOperator();
                operator_num1 = result.ToString();
                textBox1.Text = operator_num1;
                operator_num2 = "";
                operatorStatus = true;
                return;
            }
        }

        //减法运算
        private void button_sub_Click(object sender, EventArgs e)
        {
            //三种情况
            //第一种：第一个操作数还没有值，也没有进行运算
            if (operator_num1 == "")
            {
                return;
            }
            //第二种：此时第一个操作数有值了
            if (operator_num1 != "" && operator_num2 == "")
            {
                operator_pre = new SubtractionOperatorFactory().GetOperator();
                operatorStatus = true;
                return;
            }
            //第三种：此时第一个第二个操作数都有值，运算符也存在
            if (operator_num1 != "" && operator_num2 != "")
            {
                //先进行运算
                double result = operator_pre.operate(System.Convert.ToDouble(operator_num1), System.Convert.ToDouble(operator_num2));
                //然后进行设置
                operator_pre = new SubtractionOperatorFactory().GetOperator();
                operator_num1 = result.ToString();
                textBox1.Text = operator_num1;
                operator_num2 = "";
                operatorStatus = true;
                return;
            }
        }
        //加法运算
        private void button_add_Click(object sender, EventArgs e)
        {
            //三种情况
            //第一种：第一个操作数还没有值，也没有进行运算
            if (operator_num1 == "") {
                return;
            }
            //第二种：此时第一个操作数有值了
            if (operator_num1 != "" && operator_num2 == "") {
                operator_pre = new AddOperatorFactory().GetOperator();
                operatorStatus = true;
                return;
            }
            //第三种：此时第一个第二个操作数都有值，运算符也存在
            if (operator_num1 != "" && operator_num2 != "") {
                //先进行运算
                double result = operator_pre.operate(System.Convert.ToDouble(operator_num1), System.Convert.ToDouble(operator_num2));
                //然后进行设置
                operator_pre = new AddOperatorFactory().GetOperator();
                operator_num1 = result.ToString();
                textBox1.Text = operator_num1;
                operator_num2 = "";
                operatorStatus = true;
                return;
            }
        }
        //求余
        private void button_rem_Click(object sender, EventArgs e)
        {
            //三种情况
            //第一种：第一个操作数还没有值，也没有进行运算
            if (operator_num1 == "")
            {
                return;
            }
            //第二种：此时第一个操作数有值了
            if (operator_num1 != "" && operator_num2 == "")
            {
                operator_pre = new RemainderOperatorFactory().GetOperator();
                operatorStatus = true;
                
                return;
            }
            //第三种：此时第一个第二个操作数都有值，运算符也存在
            if (operator_num1 != "" && operator_num2 != "")
            {
                //先进行运算
                double result = operator_pre.operate(System.Convert.ToDouble(operator_num1), System.Convert.ToDouble(operator_num2));
                //然后进行设置
                operator_pre = new RemainderOperatorFactory().GetOperator();
                operator_num1 = result.ToString();
                textBox1.Text = operator_num1;
                operator_num2 = "";
                operatorStatus = true;
              
                return;
            }
        }
        //求倒数
        private void button_rec_Click(object sender, EventArgs e)
        {
            //三种情况
            //没有操作值
            if (operator_num1 == "")
            {
                return;
            }
            //第一个操作值
            if (operator_num1 != "" && operator_num2 == "")
            {
                SingleOperator singleOperator = new TakeReciprocalOperatorFactory().GetOperator();
                operator_num1 = "" + singleOperator.operate(System.Convert.ToDouble(operator_num1));
                textBox1.Text = operator_num1;
                return;
            }
            //第二个操作值
            if (operator_num1 != "" && operator_num2 != "")
            {
                SingleOperator singleOperator = new TakeReciprocalOperatorFactory().GetOperator();
                operator_num2 = "" + singleOperator.operate(System.Convert.ToDouble(operator_num2));
                textBox1.Text = operator_num2;
                return;
            }
        }

        //求值
        private void button22_Click(object sender, EventArgs e)
        {
            //三种情况
            //没有操作值
            if (operator_num1 == "")
            {
                return;
            }
            //第一个
            if (operator_num1 != "" && operator_num2 == "")
            {
                textBox1.Text = operator_num1;
                operator_pre = null;
                operatorStatus = true;
                return;
            }
            //第二个
            if (operator_num1 != "" && operator_num2 != "") {
                //先进行运算
                double result = operator_pre.operate(System.Convert.ToDouble(operator_num1), System.Convert.ToDouble(operator_num2));
                //然后进行设置
                operator_pre = null;
                operator_num1 = result.ToString();
                textBox1.Text = operator_num1;
                operator_num2 = "";
                operatorStatus = true;
                return;
            }
            
        }

        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("软件二班晏文威", "作者", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 查看使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("额，不要尝试错误输入（比如说1/0）哦，会出错...." +
                "其他的应该是没有问题的", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
