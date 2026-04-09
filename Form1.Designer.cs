namespace BurgerKiosk;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        labelTitle = new Label();
        groupMenu = new GroupBox();
        picChicken = new PictureBox();
        picBulgogi = new PictureBox();
        picHamburger = new PictureBox();
        radioChicken = new RadioButton();
        radioBulgogi = new RadioButton();
        radioHamburger = new RadioButton();
        groupOption = new GroupBox();
        chkSauce = new CheckBox();
        chkCheese = new CheckBox();
        chkCola = new CheckBox();
        chkPotato = new CheckBox();
        groupOrder = new GroupBox();
        listBoxOrder = new ListBox();
        lblTotal = new Label();
        btnOrder = new Button();
        btnReset = new Button();
        lblMessage = new Label();
        groupMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picBulgogi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picHamburger).BeginInit();
        groupOption.SuspendLayout();
        groupOrder.SuspendLayout();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
        labelTitle.ForeColor = Color.RoyalBlue;
        labelTitle.Location = new Point(34, 23);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(292, 46);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "버거 주문 키오스크";
        // 
        // groupMenu
        // 
        groupMenu.Controls.Add(picChicken);
        groupMenu.Controls.Add(picBulgogi);
        groupMenu.Controls.Add(picHamburger);
        groupMenu.Controls.Add(radioChicken);
        groupMenu.Controls.Add(radioBulgogi);
        groupMenu.Controls.Add(radioHamburger);
        groupMenu.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
        groupMenu.ForeColor = Color.Firebrick;
        groupMenu.Location = new Point(34, 90);
        groupMenu.Name = "groupMenu";
        groupMenu.Size = new Size(231, 252);
        groupMenu.TabIndex = 1;
        groupMenu.TabStop = false;
        groupMenu.Text = "메뉴 선택";
        // 
        // picChicken
        // 
        picChicken.BackColor = Color.MistyRose;
        picChicken.BorderStyle = BorderStyle.FixedSingle;
        picChicken.Location = new Point(135, 179);
        picChicken.Name = "picChicken";
        picChicken.Size = new Size(62, 45);
        picChicken.TabIndex = 5;
        picChicken.TabStop = false;
        // 
        // picBulgogi
        // 
        picBulgogi.BackColor = Color.Bisque;
        picBulgogi.BorderStyle = BorderStyle.FixedSingle;
        picBulgogi.Location = new Point(135, 107);
        picBulgogi.Name = "picBulgogi";
        picBulgogi.Size = new Size(62, 45);
        picBulgogi.TabIndex = 4;
        picBulgogi.TabStop = false;
        // 
        // picHamburger
        // 
        picHamburger.BackColor = Color.Wheat;
        picHamburger.BorderStyle = BorderStyle.FixedSingle;
        picHamburger.Location = new Point(135, 36);
        picHamburger.Name = "picHamburger";
        picHamburger.Size = new Size(62, 45);
        picHamburger.TabIndex = 3;
        picHamburger.TabStop = false;
        // 
        // radioChicken
        // 
        radioChicken.AutoSize = true;
        radioChicken.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        radioChicken.ForeColor = Color.Black;
        radioChicken.Location = new Point(17, 191);
        radioChicken.Name = "radioChicken";
        radioChicken.Size = new Size(85, 27);
        radioChicken.TabIndex = 2;
        radioChicken.TabStop = true;
        radioChicken.Text = "치킨버거";
        radioChicken.UseVisualStyleBackColor = true;
        // 
        // radioBulgogi
        // 
        radioBulgogi.AutoSize = true;
        radioBulgogi.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        radioBulgogi.ForeColor = Color.Black;
        radioBulgogi.Location = new Point(17, 119);
        radioBulgogi.Name = "radioBulgogi";
        radioBulgogi.Size = new Size(111, 27);
        radioBulgogi.TabIndex = 1;
        radioBulgogi.TabStop = true;
        radioBulgogi.Text = "불고기버거";
        radioBulgogi.UseVisualStyleBackColor = true;
        // 
        // radioHamburger
        // 
        radioHamburger.AutoSize = true;
        radioHamburger.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        radioHamburger.ForeColor = Color.Black;
        radioHamburger.Location = new Point(17, 48);
        radioHamburger.Name = "radioHamburger";
        radioHamburger.Size = new Size(85, 27);
        radioHamburger.TabIndex = 0;
        radioHamburger.TabStop = true;
        radioHamburger.Text = "햄버거";
        radioHamburger.UseVisualStyleBackColor = true;
        // 
        // groupOption
        // 
        groupOption.Controls.Add(chkSauce);
        groupOption.Controls.Add(chkCheese);
        groupOption.Controls.Add(chkCola);
        groupOption.Controls.Add(chkPotato);
        groupOption.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
        groupOption.ForeColor = Color.Firebrick;
        groupOption.Location = new Point(285, 90);
        groupOption.Name = "groupOption";
        groupOption.Size = new Size(182, 176);
        groupOption.TabIndex = 2;
        groupOption.TabStop = false;
        groupOption.Text = "추가 옵션";
        // 
        // chkSauce
        // 
        chkSauce.AutoSize = true;
        chkSauce.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        chkSauce.ForeColor = Color.Black;
        chkSauce.Location = new Point(17, 136);
        chkSauce.Name = "chkSauce";
        chkSauce.Size = new Size(111, 27);
        chkSauce.TabIndex = 3;
        chkSauce.Text = "소스 추가";
        chkSauce.UseVisualStyleBackColor = true;
        // 
        // chkCheese
        // 
        chkCheese.AutoSize = true;
        chkCheese.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        chkCheese.ForeColor = Color.Black;
        chkCheese.Location = new Point(17, 102);
        chkCheese.Name = "chkCheese";
        chkCheese.Size = new Size(111, 27);
        chkCheese.TabIndex = 2;
        chkCheese.Text = "치즈 추가";
        chkCheese.UseVisualStyleBackColor = true;
        // 
        // chkCola
        // 
        chkCola.AutoSize = true;
        chkCola.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        chkCola.ForeColor = Color.Black;
        chkCola.Location = new Point(17, 68);
        chkCola.Name = "chkCola";
        chkCola.Size = new Size(67, 27);
        chkCola.TabIndex = 1;
        chkCola.Text = "콜라";
        chkCola.UseVisualStyleBackColor = true;
        // 
        // chkPotato
        // 
        chkPotato.AutoSize = true;
        chkPotato.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        chkPotato.ForeColor = Color.Black;
        chkPotato.Location = new Point(17, 34);
        chkPotato.Name = "chkPotato";
        chkPotato.Size = new Size(97, 27);
        chkPotato.TabIndex = 0;
        chkPotato.Text = "감자튀김";
        chkPotato.UseVisualStyleBackColor = true;
        // 
        // groupOrder
        // 
        groupOrder.Controls.Add(listBoxOrder);
        groupOrder.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
        groupOrder.ForeColor = Color.Firebrick;
        groupOrder.Location = new Point(489, 90);
        groupOrder.Name = "groupOrder";
        groupOrder.Size = new Size(218, 176);
        groupOrder.TabIndex = 3;
        groupOrder.TabStop = false;
        groupOrder.Text = "주문 내역";
        // 
        // listBoxOrder
        // 
        listBoxOrder.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
        listBoxOrder.FormattingEnabled = true;
        listBoxOrder.ItemHeight = 23;
        listBoxOrder.Location = new Point(16, 34);
        listBoxOrder.Name = "listBoxOrder";
        listBoxOrder.Size = new Size(186, 119);
        listBoxOrder.TabIndex = 0;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblTotal.ForeColor = Color.RoyalBlue;
        lblTotal.Location = new Point(500, 290);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(130, 28);
        lblTotal.TabIndex = 4;
        lblTotal.Text = "총 금액 : 0원";
        // 
        // btnOrder
        // 
        btnOrder.BackColor = Color.LimeGreen;
        btnOrder.FlatStyle = FlatStyle.Flat;
        btnOrder.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnOrder.ForeColor = Color.White;
        btnOrder.Location = new Point(500, 345);
        btnOrder.Name = "btnOrder";
        btnOrder.Size = new Size(99, 44);
        btnOrder.TabIndex = 5;
        btnOrder.Text = "주문하기";
        btnOrder.UseVisualStyleBackColor = false;
        btnOrder.Click += btnOrder_Click;
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.Red;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
        btnReset.ForeColor = Color.White;
        btnReset.Location = new Point(608, 345);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(99, 44);
        btnReset.TabIndex = 6;
        btnReset.Text = "초기화";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += btnReset_Click;
        // 
        // lblMessage
        // 
        lblMessage.AutoSize = true;
        lblMessage.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
        lblMessage.ForeColor = Color.Red;
        lblMessage.Location = new Point(34, 360);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(0, 23);
        lblMessage.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(744, 420);
        Controls.Add(lblMessage);
        Controls.Add(btnReset);
        Controls.Add(btnOrder);
        Controls.Add(lblTotal);
        Controls.Add(groupOrder);
        Controls.Add(groupOption);
        Controls.Add(groupMenu);
        Controls.Add(labelTitle);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Burger Kiosk";
        groupMenu.ResumeLayout(false);
        groupMenu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
        ((System.ComponentModel.ISupportInitialize)picBulgogi).EndInit();
        ((System.ComponentModel.ISupportInitialize)picHamburger).EndInit();
        groupOption.ResumeLayout(false);
        groupOption.PerformLayout();
        groupOrder.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private GroupBox groupMenu;
    private PictureBox picChicken;
    private PictureBox picBulgogi;
    private PictureBox picHamburger;
    private RadioButton radioChicken;
    private RadioButton radioBulgogi;
    private RadioButton radioHamburger;
    private GroupBox groupOption;
    private CheckBox chkSauce;
    private CheckBox chkCheese;
    private CheckBox chkCola;
    private CheckBox chkPotato;
    private GroupBox groupOrder;
    private ListBox listBoxOrder;
    private Label lblTotal;
    private Button btnOrder;
    private Button btnReset;
    private Label lblMessage;
}
