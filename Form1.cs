namespace BurgerKioskWeek1;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        WireEvents();
        DrawMenuLabels();
    }

    private void WireEvents()
    {
        btnOrder.Click += (_, _) => OrderItems();
        btnReset.Click += (_, _) => ResetOrder();
    }

    private void DrawMenuLabels()
    {
        picHam.Controls.Add(CreatePictureLabel("햄버거"));
        picBulgogi.Controls.Add(CreatePictureLabel("불고기"));
        picChicken.Controls.Add(CreatePictureLabel("치킨"));
    }

    private Label CreatePictureLabel(string text)
    {
        return new Label
        {
            Dock = DockStyle.Fill,
            Text = text,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("맑은 고딕", 9F, FontStyle.Bold),
            BackColor = Color.Transparent
        };
    }

    private void OrderItems()
    {
        lstOrder.Items.Clear();

        int totalCost = 0;

        if (rdoHamBurger.Checked)
        {
            totalCost += 5000;
            lstOrder.Items.Add("햄버거 5,000원");
        }
        else if (rdoBulgogiBurger.Checked)
        {
            totalCost += 4000;
            lstOrder.Items.Add("불고기버거 4,000원");
        }
        else if (rdoChickenBurger.Checked)
        {
            totalCost += 3000;
            lstOrder.Items.Add("치킨버거 3,000원");
        }

        if (chkPotato.Checked)
        {
            totalCost += 3500;
            lstOrder.Items.Add("감자튀김 3,500원");
        }

        if (chkCola.Checked)
        {
            totalCost += 2500;
            lstOrder.Items.Add("콜라 2,500원");
        }

        if (chkCheese.Checked)
        {
            totalCost += 1500;
            lstOrder.Items.Add("치즈 추가 1,500원");
        }

        if (chkSauce.Checked)
        {
            totalCost += 500;
            lstOrder.Items.Add("소스 추가 500원");
        }

        lblTotalCost.Text = $"{totalCost:N0}원";
        lblStatus.Text = string.Empty;
    }

    private void ResetOrder()
    {
        rdoHamBurger.Checked = false;
        rdoBulgogiBurger.Checked = false;
        rdoChickenBurger.Checked = false;
        chkPotato.Checked = false;
        chkCola.Checked = false;
        chkCheese.Checked = false;
        chkSauce.Checked = false;

        lstOrder.Items.Clear();
        lblTotalCost.Text = "0원";
        lblStatus.Text = string.Empty;
        rdoHamBurger.Focus();
    }

}
