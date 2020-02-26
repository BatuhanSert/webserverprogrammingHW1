using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI.WebControls;


namespace Homework1.Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string operation, secondnumberstring,firstnumberstring;
        static int firstnumber, secondnumber,  firststringlength, secondstringlength, doubletoint;
        static double divide_op_result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "1"; }
            
            else
            { TextBox1.Text = TextBox1.Text + "1"; }
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "0"; }
            else
            { TextBox1.Text = TextBox1.Text + "0"; }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "2"; }
            else
            
            { TextBox1.Text = TextBox1.Text + "2"; }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "3"; }
            else
            { TextBox1.Text = TextBox1.Text + "3"; }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "4"; }
            
            else
            { TextBox1.Text = TextBox1.Text + "4"; }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "5"; }
            else
            { TextBox1.Text = TextBox1.Text + "5"; }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "6"; }
            else
            { TextBox1.Text = TextBox1.Text + "6"; }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "7"; }
            else
            { TextBox1.Text = TextBox1.Text + "7"; }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "8"; }
            else
            { TextBox1.Text = TextBox1.Text + "8"; }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            { TextBox1.Text = "9"; }
            else
            { TextBox1.Text = TextBox1.Text + "9"; }
        }
        protected void Button13_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "" || TextBox1.Text == "0")
            {
                TextBox1.Text = "0";
            }
            else
            {
                
                firststringlength = TextBox1.Text.Length;
                firstnumberstring = TextBox1.Text;
                firstnumber = Convert.ToInt32(TextBox1.Text);
                TextBox1.Text = TextBox1.Text + "+";
            }
            operation = "+";
   
        }
        protected void Button12_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "" || TextBox1.Text == "0")
            {
                TextBox1.Text = "-";
            }
            else
            {
                
                firststringlength = TextBox1.Text.Length;
                firstnumberstring = TextBox1.Text;
                firstnumber = Convert.ToInt32(TextBox1.Text);
                TextBox1.Text = TextBox1.Text + "-";
            }
            operation = "-";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            secondstringlength = TextBox1.Text.Length;

            if (operation != null   /*operation == "+" || operation == "-" || operation == "x" || operation == "/"*/)
            {
                
                if (firststringlength + 1 == secondstringlength) //Eğer işlemden sonra sayı gelmediyse kontrolü ex: 12+ dedikten sonra işaret değiştirmeye çalışırsa
                {
                    TextBox1.Text = TextBox1.Text;//hiçbir şey yapma
                }
                else
                {
                    secondnumberstring = TextBox1.Text.ToString();                            //Textboxdaki değeri stringe ver
                    secondnumberstring = secondnumberstring.Substring(firststringlength + 1); //ikinci değeri bulmak için stringde ilk değerden ve işlemden sonraki kısmı alınır
                    secondnumberstring = secondnumberstring.Replace("(", "");//Eğer sayıyı negatif yaptıysak başına ve sonuna koyduğumuz parantezleri kaldırıyor
                    secondnumberstring = secondnumberstring.Replace(")", "");//
                    secondnumber = Convert.ToInt32(secondnumberstring);                       //ikinci değeri stringden integera çevirme
                    if (secondnumber < 0)                                                      //ikinci değer negatif mi pozitif mi
                    {
                        secondnumber = -1 * secondnumber;                                         // ikinci değerin işaretini değiştirme
                        secondnumberstring = Convert.ToString(secondnumber);
                        TextBox1.Text = firstnumberstring + operation + secondnumberstring;
                    }
                    else
                    {
                        secondnumber = -1 * secondnumber;                                         // ikinci değerin işaretini değiştirme
                        secondnumberstring = Convert.ToString(secondnumber);
                        TextBox1.Text = firstnumberstring + operation + "(" + secondnumberstring + ")";
                    }
                    
                }
                
            }
            else                                                                                //eğer ikinci değer girilmediyse
            {
                firstnumber = Convert.ToInt32(TextBox1.Text);                                   //ilk değeri integera çevirme

                if (firstnumber < 0)
                {
                                                 
                    firstnumber = -1 * firstnumber;
                    firstnumberstring = Convert.ToString(firstnumber);
                    TextBox1.Text = firstnumberstring;
                }
                else
                {
                    firstnumber = -1 * firstnumber;
                    firstnumberstring = Convert.ToString(firstnumber);
                    TextBox1.Text = firstnumberstring;
                }
            }
   
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            {
                TextBox1.Text = "0";
            }
            else
            {
                firststringlength = TextBox1.Text.Length;
                firstnumberstring = TextBox1.Text;
                firstnumber = Convert.ToInt32(TextBox1.Text);
                TextBox1.Text = TextBox1.Text + "x";
            }
            operation = "x";
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox1.Text == "0")
            {
                TextBox1.Text = "0";
            }
            else
            {
                
                firststringlength = TextBox1.Text.Length;
                firstnumberstring = TextBox1.Text;
                firstnumber = Convert.ToInt32(TextBox1.Text);
                TextBox1.Text = TextBox1.Text + "/";
            }
            operation = "/";

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            secondnumberstring = TextBox1.Text.ToString();
            secondnumberstring = secondnumberstring.Substring(firststringlength + 1);
            secondnumberstring = secondnumberstring.Replace("(", "");//Eğer sayıyı negatif yaptıysak başına ve sonuna koyduğumuz parantezleri kaldırıyor
            secondnumberstring = secondnumberstring.Replace(")", "");//
            secondnumber = Convert.ToInt32(secondnumberstring);


            if (operation == "+")
                TextBox1.Text = Convert.ToString(firstnumber + secondnumber);
            if (operation == "-")
                TextBox1.Text = Convert.ToString(firstnumber - secondnumber);
            if (operation == "x")
                TextBox1.Text = Convert.ToString(firstnumber * secondnumber);
            if (operation == "/") 
            {   
                if (secondnumber == 0)
                {
                    TextBox1.Text = "Division-By-Zero Exception";
                    Response.AddHeader("Refresh", "2");

                    
                }
                else
                {
                    divide_op_result = Convert.ToDouble(firstnumber) / Convert.ToDouble(secondnumber);
                    doubletoint = Convert.ToInt32(divide_op_result);
                    TextBox1.Text = Convert.ToString(divide_op_result);
                    if (doubletoint != divide_op_result)
                    {
                        Response.AddHeader("Refresh", "3");
                    }
                   
                }
            }

            operation = null;


        }
        

        protected void Button16_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            operation = null;

        }

    }
}