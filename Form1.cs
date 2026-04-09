namespace BurgerKiosk;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Load += Form1_Load;
        Shown += Form1_Shown;
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        ResetScreen();
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {
        // WinForms에서 라디오버튼이 표시 시 자동 선택되는 경우를 방지하기 위한 최종 보정
        BeginInvoke(new Action(() =>
        {
            radioHamburger.Checked = false;
            radioBulgogi.Checked = false;
            radioChicken.Checked = false;
            this.ActiveControl = btnOrder;
        }));
    }

    private void ResetScreen()
    {
        radioHamburger.Checked = false;
        radioBulgogi.Checked = false;
        radioChicken.Checked = false;

        chkPotato.Checked = false;
        chkCola.Checked = false;
        chkCheese.Checked = false;
        chkSauce.Checked = false;

        listBoxOrder.Items.Clear();
        lblTotal.Text = "총 금액 : 0원";
        lblMessage.Text = "";
    }

    private void btnOrder_Click(object? sender, EventArgs e)
    {
        bool isMenuSelected =
            radioHamburger.Checked ||
            radioBulgogi.Checked ||
            radioChicken.Checked;

        // 메뉴를 선택하지 않았으면, 체크박스만 선택한 경우도 동일하게 라벨 경고 표시
        if (!isMenuSelected)
        {
            lblMessage.Text = "메뉴를 선택하세요.";
            listBoxOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";
            return;
        }

        lblMessage.Text = "";
        listBoxOrder.Items.Clear();

        int total = 0;

        if (radioHamburger.Checked)
        {
            listBoxOrder.Items.Add("햄버거 5,000원");
            total += 5000;
        }
        else if (radioBulgogi.Checked)
        {
            listBoxOrder.Items.Add("불고기버거 4,000원");
            total += 4000;
        }
        else if (radioChicken.Checked)
        {
            listBoxOrder.Items.Add("치킨버거 3,000원");
            total += 3000;
        }

        if (chkPotato.Checked)
        {
            listBoxOrder.Items.Add("감자튀김 3,500원");
            total += 3500;
        }

        if (chkCola.Checked)
        {
            listBoxOrder.Items.Add("콜라 2,500원");
            total += 2500;
        }

        if (chkCheese.Checked)
        {
            listBoxOrder.Items.Add("치즈 추가 1,500원");
            total += 1500;
        }

        if (chkSauce.Checked)
        {
            listBoxOrder.Items.Add("소스 추가 500원");
            total += 500;
        }

        lblTotal.Text = "총 금액 : " + total.ToString("N0") + "원";
    }

    private void btnReset_Click(object? sender, EventArgs e)
    {
        ResetScreen();

        BeginInvoke(new Action(() =>
        {
            radioHamburger.Checked = false;
            radioBulgogi.Checked = false;
            radioChicken.Checked = false;
            this.ActiveControl = btnOrder;
        }));
    }
}
