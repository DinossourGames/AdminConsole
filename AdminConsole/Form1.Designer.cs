namespace AdminConsole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnPoolStart = new System.Windows.Forms.Button();
            this.btnPoolEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemDurability = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemAttack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemRange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemDefense = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemHealth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemLucky = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMoveSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbAddStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.item1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.item2 = new System.Windows.Forms.Label();
            this.item3 = new System.Windows.Forms.Label();
            this.item4 = new System.Windows.Forms.Label();
            this.voto4 = new System.Windows.Forms.Label();
            this.voto3 = new System.Windows.Forms.Label();
            this.voto2 = new System.Windows.Forms.Label();
            this.voto1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.pbServerStatus = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.pAtk = new System.Windows.Forms.TextBox();
            this.pDef = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pRange = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pLucky = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pHp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pMaxHp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pSpeed = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemsDetails = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pOnline = new System.Windows.Forms.Label();
            this.pX = new System.Windows.Forms.Label();
            this.pY = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(16, 352);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(94, 38);
            this.btnItem.TabIndex = 13;
            this.btnItem.Text = "Novo Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // btnPoolStart
            // 
            this.btnPoolStart.Location = new System.Drawing.Point(434, 200);
            this.btnPoolStart.Name = "btnPoolStart";
            this.btnPoolStart.Size = new System.Drawing.Size(79, 42);
            this.btnPoolStart.TabIndex = 1;
            this.btnPoolStart.Text = "Criar Pool";
            this.btnPoolStart.UseVisualStyleBackColor = true;
            this.btnPoolStart.Click += new System.EventHandler(this.BtnPoolStart_Click);
            // 
            // btnPoolEnd
            // 
            this.btnPoolEnd.Location = new System.Drawing.Point(258, 195);
            this.btnPoolEnd.Name = "btnPoolEnd";
            this.btnPoolEnd.Size = new System.Drawing.Size(81, 42);
            this.btnPoolEnd.TabIndex = 2;
            this.btnPoolEnd.Text = "Encerrar Pool";
            this.btnPoolEnd.UseVisualStyleBackColor = true;
            this.btnPoolEnd.Click += new System.EventHandler(this.BtnPoolEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(86, 43);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(122, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(86, 69);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(122, 42);
            this.txtItemDesc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // txtItemDurability
            // 
            this.txtItemDurability.Location = new System.Drawing.Point(86, 117);
            this.txtItemDurability.Name = "txtItemDurability";
            this.txtItemDurability.Size = new System.Drawing.Size(122, 20);
            this.txtItemDurability.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Durabilidade";
            // 
            // txtItemAttack
            // 
            this.txtItemAttack.Location = new System.Drawing.Point(86, 169);
            this.txtItemAttack.Name = "txtItemAttack";
            this.txtItemAttack.Size = new System.Drawing.Size(122, 20);
            this.txtItemAttack.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ataque";
            // 
            // txtItemRange
            // 
            this.txtItemRange.Location = new System.Drawing.Point(86, 195);
            this.txtItemRange.Name = "txtItemRange";
            this.txtItemRange.Size = new System.Drawing.Size(122, 20);
            this.txtItemRange.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Range";
            // 
            // txtItemDefense
            // 
            this.txtItemDefense.Location = new System.Drawing.Point(86, 221);
            this.txtItemDefense.Name = "txtItemDefense";
            this.txtItemDefense.Size = new System.Drawing.Size(122, 20);
            this.txtItemDefense.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Defesa";
            // 
            // txtItemHealth
            // 
            this.txtItemHealth.Location = new System.Drawing.Point(86, 247);
            this.txtItemHealth.Name = "txtItemHealth";
            this.txtItemHealth.Size = new System.Drawing.Size(122, 20);
            this.txtItemHealth.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vida";
            // 
            // txtItemLucky
            // 
            this.txtItemLucky.Location = new System.Drawing.Point(86, 273);
            this.txtItemLucky.Name = "txtItemLucky";
            this.txtItemLucky.Size = new System.Drawing.Size(122, 20);
            this.txtItemLucky.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sorte";
            // 
            // txtMoveSpeed
            // 
            this.txtMoveSpeed.Location = new System.Drawing.Point(86, 299);
            this.txtMoveSpeed.Name = "txtMoveSpeed";
            this.txtMoveSpeed.Size = new System.Drawing.Size(122, 20);
            this.txtMoveSpeed.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Move Speed";
            // 
            // pbAddStatus
            // 
            this.pbAddStatus.BackColor = System.Drawing.Color.Gray;
            this.pbAddStatus.Location = new System.Drawing.Point(314, 343);
            this.pbAddStatus.Name = "pbAddStatus";
            this.pbAddStatus.Size = new System.Drawing.Size(42, 38);
            this.pbAddStatus.TabIndex = 24;
            this.pbAddStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(236, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 416);
            this.panel1.TabIndex = 25;
            // 
            // item1
            // 
            this.item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1.Location = new System.Drawing.Point(269, 72);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(200, 20);
            this.item1.TabIndex = 26;
            this.item1.Text = "Item";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(369, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pool";
            // 
            // item2
            // 
            this.item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2.Location = new System.Drawing.Point(269, 98);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(200, 20);
            this.item2.TabIndex = 28;
            this.item2.Text = "Item";
            // 
            // item3
            // 
            this.item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3.Location = new System.Drawing.Point(269, 124);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(200, 20);
            this.item3.TabIndex = 29;
            this.item3.Text = "Item";
            // 
            // item4
            // 
            this.item4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item4.Location = new System.Drawing.Point(269, 145);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(200, 20);
            this.item4.TabIndex = 30;
            this.item4.Text = "Item";
            // 
            // voto4
            // 
            this.voto4.AutoSize = true;
            this.voto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto4.Location = new System.Drawing.Point(486, 145);
            this.voto4.Name = "voto4";
            this.voto4.Size = new System.Drawing.Size(27, 20);
            this.voto4.TabIndex = 34;
            this.voto4.Text = "10";
            this.voto4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // voto3
            // 
            this.voto3.AutoSize = true;
            this.voto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto3.Location = new System.Drawing.Point(486, 124);
            this.voto3.Name = "voto3";
            this.voto3.Size = new System.Drawing.Size(27, 20);
            this.voto3.TabIndex = 33;
            this.voto3.Text = "10";
            this.voto3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // voto2
            // 
            this.voto2.AutoSize = true;
            this.voto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto2.Location = new System.Drawing.Point(486, 98);
            this.voto2.Name = "voto2";
            this.voto2.Size = new System.Drawing.Size(27, 20);
            this.voto2.TabIndex = 32;
            this.voto2.Text = "10";
            this.voto2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // voto1
            // 
            this.voto1.AutoSize = true;
            this.voto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voto1.Location = new System.Drawing.Point(486, 72);
            this.voto1.Name = "voto1";
            this.voto1.Size = new System.Drawing.Size(27, 20);
            this.voto1.TabIndex = 31;
            this.voto1.Text = "10";
            this.voto1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 58);
            this.button1.TabIndex = 35;
            this.button1.Text = "Encerrar Pool Com Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(624, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 24);
            this.label21.TabIndex = 37;
            this.label21.Text = "Player";
            // 
            // pbServerStatus
            // 
            this.pbServerStatus.BackColor = System.Drawing.Color.Silver;
            this.pbServerStatus.Location = new System.Drawing.Point(362, 365);
            this.pbServerStatus.Name = "pbServerStatus";
            this.pbServerStatus.Size = new System.Drawing.Size(16, 16);
            this.pbServerStatus.TabIndex = 43;
            this.pbServerStatus.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(384, 365);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 16);
            this.label27.TabIndex = 44;
            this.label27.Text = "Server Status";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemCost
            // 
            this.txtItemCost.Location = new System.Drawing.Point(86, 144);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(122, 20);
            this.txtItemCost.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cost";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(86, 325);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(122, 20);
            this.txtImageUrl.TabIndex = 11;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 328);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Image URL";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 364);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "IsLootBoxItem";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(404, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1800;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Request Status";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 38);
            this.button2.TabIndex = 53;
            this.button2.Text = "Update Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(628, 373);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 17);
            this.cbUpdate.TabIndex = 54;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            this.cbUpdate.CheckedChanged += new System.EventHandler(this.CbUpdate_CheckedChanged);
            // 
            // pAtk
            // 
            this.pAtk.Location = new System.Drawing.Point(609, 50);
            this.pAtk.Name = "pAtk";
            this.pAtk.Size = new System.Drawing.Size(122, 20);
            this.pAtk.TabIndex = 55;
            // 
            // pDef
            // 
            this.pDef.Location = new System.Drawing.Point(609, 74);
            this.pDef.Name = "pDef";
            this.pDef.Size = new System.Drawing.Size(122, 20);
            this.pDef.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(564, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Defesa";
            // 
            // pRange
            // 
            this.pRange.Location = new System.Drawing.Point(609, 100);
            this.pRange.Name = "pRange";
            this.pRange.Size = new System.Drawing.Size(122, 20);
            this.pRange.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Range";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(564, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "IsPlaying";
            // 
            // pLucky
            // 
            this.pLucky.Location = new System.Drawing.Point(609, 150);
            this.pLucky.Name = "pLucky";
            this.pLucky.Size = new System.Drawing.Size(122, 20);
            this.pLucky.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(564, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Sorte";
            // 
            // pHp
            // 
            this.pHp.Location = new System.Drawing.Point(609, 176);
            this.pHp.Name = "pHp";
            this.pHp.Size = new System.Drawing.Size(122, 20);
            this.pHp.TabIndex = 65;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(564, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 66;
            this.label19.Text = "Hp";
            // 
            // pMaxHp
            // 
            this.pMaxHp.Location = new System.Drawing.Point(609, 202);
            this.pMaxHp.Name = "pMaxHp";
            this.pMaxHp.Size = new System.Drawing.Size(122, 20);
            this.pMaxHp.TabIndex = 67;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(564, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 68;
            this.label20.Text = "Max Hp";
            // 
            // pSpeed
            // 
            this.pSpeed.Location = new System.Drawing.Point(609, 228);
            this.pSpeed.Name = "pSpeed";
            this.pSpeed.Size = new System.Drawing.Size(122, 20);
            this.pSpeed.TabIndex = 69;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(564, 231);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 70;
            this.label22.Text = "Speed";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(564, 257);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 72;
            this.label23.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(541, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 426);
            this.panel2.TabIndex = 26;
            // 
            // itemsDetails
            // 
            this.itemsDetails.AutoEllipsis = true;
            this.itemsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsDetails.Location = new System.Drawing.Point(766, 43);
            this.itemsDetails.Name = "itemsDetails";
            this.itemsDetails.Size = new System.Drawing.Size(222, 347);
            this.itemsDetails.TabIndex = 83;
            this.itemsDetails.Text = "Nome";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(847, 9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(92, 24);
            this.label39.TabIndex = 80;
            this.label39.Text = "Atual Item";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(564, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 101;
            this.label14.Text = "Ataque";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-16, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 3);
            this.panel3.TabIndex = 102;
            // 
            // pOnline
            // 
            this.pOnline.AutoSize = true;
            this.pOnline.Location = new System.Drawing.Point(651, 129);
            this.pOnline.Name = "pOnline";
            this.pOnline.Size = new System.Drawing.Size(32, 13);
            this.pOnline.TabIndex = 103;
            this.pOnline.Text = "False";
            // 
            // pX
            // 
            this.pX.AutoSize = true;
            this.pX.Location = new System.Drawing.Point(657, 257);
            this.pX.Name = "pX";
            this.pX.Size = new System.Drawing.Size(14, 13);
            this.pX.TabIndex = 104;
            this.pX.Text = "X";
            // 
            // pY
            // 
            this.pY.AutoSize = true;
            this.pY.Location = new System.Drawing.Point(657, 281);
            this.pY.Name = "pY";
            this.pY.Size = new System.Drawing.Size(14, 13);
            this.pY.TabIndex = 106;
            this.pY.Text = "Y";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(564, 281);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 105;
            this.label25.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 414);
            this.Controls.Add(this.pY);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pX);
            this.Controls.Add(this.pOnline);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.itemsDetails);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pSpeed);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pMaxHp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pHp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pLucky);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pRange);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pDef);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pAtk);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.pbServerStatus);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.voto4);
            this.Controls.Add(this.voto3);
            this.Controls.Add(this.voto2);
            this.Controls.Add(this.voto1);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbAddStatus);
            this.Controls.Add(this.txtMoveSpeed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtItemLucky);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtItemHealth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtItemDefense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItemRange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemAttack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemDurability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPoolEnd);
            this.Controls.Add(this.btnPoolStart);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.label27);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnPoolStart;
        private System.Windows.Forms.Button btnPoolEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemDurability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemAttack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemDefense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemHealth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemLucky;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMoveSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbAddStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.Label item3;
        private System.Windows.Forms.Label item4;
        private System.Windows.Forms.Label voto4;
        private System.Windows.Forms.Label voto3;
        private System.Windows.Forms.Label voto2;
        private System.Windows.Forms.Label voto1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pbServerStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.TextBox pAtk;
        private System.Windows.Forms.TextBox pDef;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pRange;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox pLucky;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox pHp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pMaxHp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox pSpeed;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label itemsDetails;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pOnline;
        private System.Windows.Forms.Label pX;
        private System.Windows.Forms.Label pY;
        private System.Windows.Forms.Label label25;
    }
}

