using System;
namespace Calculator
{
    public class buttonHandler
    {
        

        public static void btn_clear_Click(object sender, EventArgs e)
        {
            numberHandler.resetNumbers();
            Calculator.Instance.resetDisplay();
        }

        public static void btn_div_Click(object sender, EventArgs e) => numberHandler.operation('/');
        public static void btn_mul_Click(object sender, EventArgs e) => numberHandler.operation('*');
        public static void btn_sub_Click(object sender, EventArgs e) => numberHandler.operation('-');
        public static void btn_add_Click(object sender, EventArgs e) => numberHandler.operation('+');

        public static void btn_0_Click(object sender, EventArgs e) => numberHandler.setNumbers(0);
        public static void btn_1_Click(object sender, EventArgs e) => numberHandler.setNumbers(1);
        public static void btn_2_Click(object sender, EventArgs e) => numberHandler.setNumbers(2);
        public static void btn_3_Click(object sender, EventArgs e) => numberHandler.setNumbers(3);
        public static void btn_4_Click(object sender, EventArgs e) => numberHandler.setNumbers(4);
        public static void btn_5_Click(object sender, EventArgs e) => numberHandler.setNumbers(5);
        public static void btn_6_Click(object sender, EventArgs e) => numberHandler.setNumbers(6);
        public static void btn_7_Click(object sender, EventArgs e) => numberHandler.setNumbers(7);
        public static void btn_8_Click(object sender, EventArgs e) => numberHandler.setNumbers(8);
        public static void btn_9_Click(object sender, EventArgs e) => numberHandler.setNumbers(9);
    }
}