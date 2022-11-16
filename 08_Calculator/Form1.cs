namespace _08_Calculator
{
    public partial class Form1 : Form
    {
        private delegate double CalculationHandler(int x, int y);
        private CalculationHandler operation;
        private string operant1;
        private string operant2;
        public Form1()
        {
            InitializeComponent();
            this.btn0.Click += BtnNumberClick;      //dem Event (delegate) Click eine Methode zugewiesen
            this.btn1.Click += BtnNumberClick;
            this.btn2.Click += BtnNumberClick;
            this.btn3.Click += BtnNumberClick;
            this.btn4.Click += BtnNumberClick;
            this.btn5.Click += BtnNumberClick;
            this.btn6.Click += BtnNumberClick;
            this.btn7.Click += BtnNumberClick;
            this.btn8.Click += BtnNumberClick;
            this.btn9.Click += BtnNumberClick;

        }

        private void BtnNumberClick(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;        //nachdem nur Buttons als Sender in Frage kommen --> cast
            string number = btn.Text;

           if(this.operation == null)
            {
                //es ist noch keine Operator gewählt
                this.operant1 += number;
                this.txtdisplay.Text = this.operant1;
            }


            if(this.operation != null)      //wir haben bereits eine Rechenoperation ausgewählt
            {
                this.operant2 += number;
                this.txtdisplay.Text += number;
            }
        }

        private double Addition(int x, int y)
        {
            return x + y;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            // es soll als Rechenoperation die Addition ausgewählt werden
            if(this.txtdisplay.Text != "" && this.operation == null)        //es darf noch keine Rechenoperation ausgewählt sein
            {
             operation += Addition;
             this.operant1 = this.txtdisplay.Text;     
             this.txtdisplay.Text += " + ";
            }
        }

        private double Subthraktion(int x, int y)
        {
            return x - y;
        }

        private void BtnSubthraktion_Click(object sender, EventArgs e)
        {

        }

        private double Multiplikation(int x, int y)
        {
            return x * y;
        }


        private void btnMultipikation_Click(object sender, EventArgs e)
        {

        }

        private double Division(int x, int y)
        {
            return x / (double)y;
        }


        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(this.operant1 != "" && this.operant2 != "" && this.operation != null)
            {
                int x = int.Parse(this.operant1);
                int y = int.Parse(this.operant2);


                if (operation != null)           //sollte immer eine Wert haben
                {
                    double result = operation(x, y);
                    this.txtdisplay.Text += " = " + result;

                    //reset des Calculators
                    this.operation -= Addition;
                    this.operation -= Subthraktion;
                    this.operation -= Division;
                    this.operation -= Multiplikation;       //Abmelden der Operationen

                    this.operant1 = "";
                    this.operant2 = "";
                }
            }
        }
    }
}