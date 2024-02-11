namespace Impuesto_Sobre_Renta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Pago_Hora, Horas_Trabajadas, Sueldo_Bruto, AFP, SFS, Sueldo_Neto, Total_Descuento, Sueldo_Anual, ISR;

            Pago_Hora = Double.Parse(txt_Pago_Hora.Text);
            Horas_Trabajadas = Double.Parse(txt_Horas_Trabajadas.Text);


            Sueldo_Bruto= Pago_Hora * Horas_Trabajadas;

            AFP= Sueldo_Bruto * 0.0287;
            SFS= Sueldo_Bruto * 0.034;

            Total_Descuento= AFP+SFS;

            Sueldo_Neto= Sueldo_Bruto-Total_Descuento;
            Sueldo_Anual= Sueldo_Neto*12;

            txt_Sueldo_Bruto.Text= Sueldo_Bruto.ToString();
            txt_AFP.Text= AFP.ToString();
            txt_SFS.Text= SFS.ToString();
            txt_Sueldo_Neto.Text= Sueldo_Neto.ToString();
            txt_Total_Descuento.Text= Total_Descuento.ToString();
            txt_Sueldo_Anual.Text= Sueldo_Anual.ToString();



            if (Sueldo_Anual <=416220.00)
            {
                ISR=0;
                txt_ISR.Text = "Excepto";

            }

            else if (Sueldo_Anual >= 416220.01 && Sueldo_Anual <= 624329.00)
            {
                ISR = ((Sueldo_Anual - 416220.01) * 0.15)/12;

            }

            else if (Sueldo_Anual>= 624329.01 && Sueldo_Anual <= 867123.00)
            {
                ISR = (31216+ (Sueldo_Anual - 624329.01) * 0.20)/12;
            }

            else
            {
                ISR=(79726.00+ (Sueldo_Anual - 867123.00) * 0.25)/12;
            }
            txt_ISR.Text= ISR.ToString();



        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Pago_Hora.Clear();
            txt_Horas_Trabajadas.Clear();
            txt_Sueldo_Bruto.Clear();
            txt_AFP.Clear();
            txt_SFS.Clear();
            txt_Total_Descuento.Clear();
            txt_Sueldo_Neto.Clear();
            txt_Sueldo_Anual.Clear();
            txt_ISR.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
