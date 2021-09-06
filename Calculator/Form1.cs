using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{public partial class Form1 : Form{public Form1(){InitializeComponent();} float a, b; int count; bool znak = true;
private void button17_Click(object sender, EventArgs e){textBox1.Text = textBox1.Text + (sender as Button).Text;}
private void calculate()
{switch (count){case 1:
  b = a + float.Parse(textBox1.Text); textBox1.Text = b.ToString(); break; case 2:
  b = a - float.Parse(textBox1.Text); textBox1.Text = b.ToString(); break; case 3:
  b = a * float.Parse(textBox1.Text); textBox1.Text = b.ToString(); break; case 4:
  b = a / float.Parse(textBox1.Text); textBox1.Text = b.ToString(); break; default: break;}}
private void button4_Click(object sender, EventArgs e)
{a = float.Parse(textBox1.Text); textBox1.Clear(); count = 1; label1.Text = a.ToString() + "+"; znak = true;}
private void button8_Click(object sender, EventArgs e)
{a = float.Parse(textBox1.Text); textBox1.Clear(); count = 2; label1.Text = a.ToString() + "-"; znak = true;}
private void button12_Click(object sender, EventArgs e)
{a = float.Parse(textBox1.Text); textBox1.Clear(); count = 3; label1.Text = a.ToString() + "*"; znak = true;}
private void button16_Click(object sender, EventArgs e)
{a = float.Parse(textBox1.Text); textBox1.Clear(); count = 4; label1.Text = a.ToString() + "/"; znak = true;}
private void button19_Click(object sender, EventArgs e){calculate(); label1.Text = "";}
private void button3_Click(object sender, EventArgs e){textBox1.Text = ""; label1.Text = "";}
private void Form1_Load(object sender, EventArgs e){}}}