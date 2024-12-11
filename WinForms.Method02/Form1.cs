namespace WinForms.Method02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //double r = 0;
            //if (!double.TryParse(txtRadius.Text, out r))
            //{
            //    MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //    return;
            //}
            //CircleArea(r);   //���¡�� Void Method �觤�� double

            //CircleArea(txtRadius);   //���¡�� viod method Ẻ�� textbox
            CircleArea(txtRadius, lblResult);
        }

        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lblResult.Text = area.ToString();
        }

        void CircleArea(TextBox txt)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            double area = Math.PI * r * r;
            lblResult.Text = area.ToString();
        }
        void CircleArea(TextBox txt, Label lbl)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return;
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString();
        }
    }
}
