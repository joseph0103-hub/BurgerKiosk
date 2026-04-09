namespace BurgerKiosk;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Load += Form1_Load;
        Shown += Form1_Shown;
        KeyPreview = true;
        KeyDown += Form1_KeyDown;
        AcceptButton = btnOrder;
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        ResetScreen();
        ConfigureKeyboardFlow();
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {
        BeginInvoke(new Action(() =>
        {
            radioHamburger.Checked = false;
            radioBulgogi.Checked = false;
            radioChicken.Checked = false;
            ActiveControl = radioHamburger;
        }));
    }

    private void ConfigureKeyboardFlow()
    {
        // Tab 이동 순서: 메뉴 그룹 -> 옵션 그룹 -> 주문 버튼 -> 초기화 버튼
        radioHamburger.TabIndex = 0;
        radioBulgogi.TabIndex = 1;
        radioChicken.TabIndex = 2;

        chkPotato.TabIndex = 3;
        chkCola.TabIndex = 4;
        chkCheese.TabIndex = 5;
        chkSauce.TabIndex = 6;

        btnOrder.TabIndex = 7;
        btnReset.TabIndex = 8;

        groupMenu.TabStop = false;
        groupOption.TabStop = false;
        groupOrder.TabStop = false;
    }

    private void Form1_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnOrder.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
            return;
        }

        if (e.KeyCode == Keys.Tab && ActiveControl == btnReset && e.Shift == false)
        {
            BeginInvoke(new Action(() => radioHamburger.Focus()));
        }
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

    private bool IsMenuSelected()
    {
        return radioHamburger.Checked || radioBulgogi.Checked || radioChicken.Checked;
    }

    private void BuildOrder()
    {
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

    private void btnOrder_Click(object? sender, EventArgs e)
    {
        if (!IsMenuSelected())
        {
            lblMessage.Text = "메뉴를 먼저 선택한 후 옵션을 선택하세요.";
            listBoxOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";
            return;
        }

        lblMessage.Text = "";
        BuildOrder();
    }

    private void btnReset_Click(object? sender, EventArgs e)
    {
        ResetScreen();

        BeginInvoke(new Action(() =>
        {
            radioHamburger.Checked = false;
            radioBulgogi.Checked = false;
            radioChicken.Checked = false;
            ActiveControl = radioHamburger;
        }));
    }
}
