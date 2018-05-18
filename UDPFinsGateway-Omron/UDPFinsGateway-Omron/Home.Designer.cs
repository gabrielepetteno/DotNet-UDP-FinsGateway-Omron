namespace UDPFinsGateway_Omron
{
    partial class Home1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reset_Impostazioni = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Salva_Impostazioni = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PLCPingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Tema_Dark = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Tema_Light = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PcGetIPButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_IP_PC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_Port_PC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Input_IP_PLC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Input_Port_PLC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Input_ICF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_RSV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Input_GCT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_DNA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_DA1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_DA2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_SNA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_SA1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.Input_SA2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.Write_Button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Write_DM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Write_Value = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Read_Num = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Read_DM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Read_Button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Read_Result = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Reset_Impostazioni
            // 
            this.Reset_Impostazioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reset_Impostazioni.Depth = 0;
            this.Reset_Impostazioni.Location = new System.Drawing.Point(10, 301);
            this.Reset_Impostazioni.MouseState = MaterialSkin.MouseState.HOVER;
            this.Reset_Impostazioni.Name = "Reset_Impostazioni";
            this.Reset_Impostazioni.Primary = true;
            this.Reset_Impostazioni.Size = new System.Drawing.Size(74, 36);
            this.Reset_Impostazioni.TabIndex = 70;
            this.Reset_Impostazioni.Text = "Reset";
            this.Reset_Impostazioni.UseVisualStyleBackColor = true;
            this.Reset_Impostazioni.Click += new System.EventHandler(this.Reset_Impostazioni_Click);
            // 
            // Salva_Impostazioni
            // 
            this.Salva_Impostazioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Salva_Impostazioni.Depth = 0;
            this.Salva_Impostazioni.Location = new System.Drawing.Point(90, 301);
            this.Salva_Impostazioni.MouseState = MaterialSkin.MouseState.HOVER;
            this.Salva_Impostazioni.Name = "Salva_Impostazioni";
            this.Salva_Impostazioni.Primary = true;
            this.Salva_Impostazioni.Size = new System.Drawing.Size(74, 36);
            this.Salva_Impostazioni.TabIndex = 68;
            this.Salva_Impostazioni.Text = "SAVE";
            this.Salva_Impostazioni.UseVisualStyleBackColor = true;
            this.Salva_Impostazioni.Click += new System.EventHandler(this.Salva_Impostazioni_Click);
            // 
            // PLCPingButton
            // 
            this.PLCPingButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PLCPingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PLCPingButton.Depth = 0;
            this.PLCPingButton.Location = new System.Drawing.Point(360, 189);
            this.PLCPingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PLCPingButton.Name = "PLCPingButton";
            this.PLCPingButton.Primary = true;
            this.PLCPingButton.Size = new System.Drawing.Size(64, 36);
            this.PLCPingButton.TabIndex = 73;
            this.PLCPingButton.Text = "Ping";
            this.PLCPingButton.UseVisualStyleBackColor = true;
            this.PLCPingButton.Click += new System.EventHandler(this.PLCPingButton_Click);
            // 
            // Tema_Dark
            // 
            this.Tema_Dark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tema_Dark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tema_Dark.Depth = 0;
            this.Tema_Dark.Location = new System.Drawing.Point(799, 74);
            this.Tema_Dark.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tema_Dark.Name = "Tema_Dark";
            this.Tema_Dark.Primary = true;
            this.Tema_Dark.Size = new System.Drawing.Size(64, 36);
            this.Tema_Dark.TabIndex = 75;
            this.Tema_Dark.Text = "Dark";
            this.Tema_Dark.UseVisualStyleBackColor = true;
            this.Tema_Dark.Click += new System.EventHandler(this.Tema_Dark_Click);
            // 
            // Tema_Light
            // 
            this.Tema_Light.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tema_Light.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tema_Light.Depth = 0;
            this.Tema_Light.Location = new System.Drawing.Point(724, 74);
            this.Tema_Light.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tema_Light.Name = "Tema_Light";
            this.Tema_Light.Primary = true;
            this.Tema_Light.Size = new System.Drawing.Size(64, 36);
            this.Tema_Light.TabIndex = 76;
            this.Tema_Light.Text = "Light";
            this.Tema_Light.UseVisualStyleBackColor = true;
            this.Tema_Light.Click += new System.EventHandler(this.Tema_Light_Click);
            // 
            // PcGetIPButton
            // 
            this.PcGetIPButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PcGetIPButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PcGetIPButton.Depth = 0;
            this.PcGetIPButton.Location = new System.Drawing.Point(360, 81);
            this.PcGetIPButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PcGetIPButton.Name = "PcGetIPButton";
            this.PcGetIPButton.Primary = true;
            this.PcGetIPButton.Size = new System.Drawing.Size(64, 36);
            this.PcGetIPButton.TabIndex = 92;
            this.PcGetIPButton.Text = "GET";
            this.PcGetIPButton.UseVisualStyleBackColor = true;
            this.PcGetIPButton.Click += new System.EventHandler(this.PcGetIPButton_Click);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(83, 91);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(45, 19);
            this.materialLabel14.TabIndex = 102;
            this.materialLabel14.Text = "IP PC";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_IP_PC
            // 
            this.Input_IP_PC.Depth = 0;
            this.Input_IP_PC.Hint = "";
            this.Input_IP_PC.Location = new System.Drawing.Point(135, 87);
            this.Input_IP_PC.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_IP_PC.Name = "Input_IP_PC";
            this.Input_IP_PC.PasswordChar = '\0';
            this.Input_IP_PC.SelectedText = "";
            this.Input_IP_PC.SelectionLength = 0;
            this.Input_IP_PC.SelectionStart = 0;
            this.Input_IP_PC.Size = new System.Drawing.Size(196, 23);
            this.Input_IP_PC.TabIndex = 103;
            this.Input_IP_PC.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(59, 128);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(69, 19);
            this.materialLabel15.TabIndex = 104;
            this.materialLabel15.Text = "PC PORT";
            this.materialLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(75, 167);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(53, 19);
            this.materialLabel16.TabIndex = 105;
            this.materialLabel16.Text = "IP PLC";
            this.materialLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(51, 206);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(77, 19);
            this.materialLabel17.TabIndex = 106;
            this.materialLabel17.Text = "PLC PORT";
            this.materialLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_Port_PC
            // 
            this.Input_Port_PC.Depth = 0;
            this.Input_Port_PC.Hint = "";
            this.Input_Port_PC.Location = new System.Drawing.Point(134, 124);
            this.Input_Port_PC.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_Port_PC.Name = "Input_Port_PC";
            this.Input_Port_PC.PasswordChar = '\0';
            this.Input_Port_PC.SelectedText = "";
            this.Input_Port_PC.SelectionLength = 0;
            this.Input_Port_PC.SelectionStart = 0;
            this.Input_Port_PC.Size = new System.Drawing.Size(196, 23);
            this.Input_Port_PC.TabIndex = 107;
            this.Input_Port_PC.UseSystemPasswordChar = false;
            // 
            // Input_IP_PLC
            // 
            this.Input_IP_PLC.Depth = 0;
            this.Input_IP_PLC.Hint = "";
            this.Input_IP_PLC.Location = new System.Drawing.Point(135, 163);
            this.Input_IP_PLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_IP_PLC.Name = "Input_IP_PLC";
            this.Input_IP_PLC.PasswordChar = '\0';
            this.Input_IP_PLC.SelectedText = "";
            this.Input_IP_PLC.SelectionLength = 0;
            this.Input_IP_PLC.SelectionStart = 0;
            this.Input_IP_PLC.Size = new System.Drawing.Size(196, 23);
            this.Input_IP_PLC.TabIndex = 108;
            this.Input_IP_PLC.UseSystemPasswordChar = false;
            // 
            // Input_Port_PLC
            // 
            this.Input_Port_PLC.Depth = 0;
            this.Input_Port_PLC.Hint = "";
            this.Input_Port_PLC.Location = new System.Drawing.Point(134, 202);
            this.Input_Port_PLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_Port_PLC.Name = "Input_Port_PLC";
            this.Input_Port_PLC.PasswordChar = '\0';
            this.Input_Port_PLC.SelectedText = "";
            this.Input_Port_PLC.SelectionLength = 0;
            this.Input_Port_PLC.SelectionStart = 0;
            this.Input_Port_PLC.Size = new System.Drawing.Size(196, 23);
            this.Input_Port_PLC.TabIndex = 109;
            this.Input_Port_PLC.UseSystemPasswordChar = false;
            // 
            // Input_ICF
            // 
            this.Input_ICF.Depth = 0;
            this.Input_ICF.Hint = "";
            this.Input_ICF.Location = new System.Drawing.Point(56, 254);
            this.Input_ICF.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_ICF.Name = "Input_ICF";
            this.Input_ICF.PasswordChar = '\0';
            this.Input_ICF.SelectedText = "";
            this.Input_ICF.SelectionLength = 0;
            this.Input_ICF.SelectionStart = 0;
            this.Input_ICF.Size = new System.Drawing.Size(41, 23);
            this.Input_ICF.TabIndex = 110;
            this.Input_ICF.UseSystemPasswordChar = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(10, 254);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(40, 23);
            this.materialLabel18.TabIndex = 111;
            this.materialLabel18.Text = "ICF";
            this.materialLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(121, 254);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(40, 23);
            this.materialLabel5.TabIndex = 112;
            this.materialLabel5.Text = "RSV";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_RSV
            // 
            this.Input_RSV.Depth = 0;
            this.Input_RSV.Hint = "";
            this.Input_RSV.Location = new System.Drawing.Point(167, 254);
            this.Input_RSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_RSV.Name = "Input_RSV";
            this.Input_RSV.PasswordChar = '\0';
            this.Input_RSV.SelectedText = "";
            this.Input_RSV.SelectionLength = 0;
            this.Input_RSV.SelectionStart = 0;
            this.Input_RSV.Size = new System.Drawing.Size(41, 23);
            this.Input_RSV.TabIndex = 113;
            this.Input_RSV.UseSystemPasswordChar = false;
            // 
            // Input_GCT
            // 
            this.Input_GCT.Depth = 0;
            this.Input_GCT.Hint = "";
            this.Input_GCT.Location = new System.Drawing.Point(278, 254);
            this.Input_GCT.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_GCT.Name = "Input_GCT";
            this.Input_GCT.PasswordChar = '\0';
            this.Input_GCT.SelectedText = "";
            this.Input_GCT.SelectionLength = 0;
            this.Input_GCT.SelectionStart = 0;
            this.Input_GCT.Size = new System.Drawing.Size(41, 23);
            this.Input_GCT.TabIndex = 115;
            this.Input_GCT.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(232, 254);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 23);
            this.materialLabel6.TabIndex = 114;
            this.materialLabel6.Text = "GCT";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_DNA
            // 
            this.Input_DNA.Depth = 0;
            this.Input_DNA.Hint = "";
            this.Input_DNA.Location = new System.Drawing.Point(389, 254);
            this.Input_DNA.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_DNA.Name = "Input_DNA";
            this.Input_DNA.PasswordChar = '\0';
            this.Input_DNA.SelectedText = "";
            this.Input_DNA.SelectionLength = 0;
            this.Input_DNA.SelectionStart = 0;
            this.Input_DNA.Size = new System.Drawing.Size(41, 23);
            this.Input_DNA.TabIndex = 117;
            this.Input_DNA.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(343, 254);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(40, 23);
            this.materialLabel7.TabIndex = 116;
            this.materialLabel7.Text = "DNA";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_DA1
            // 
            this.Input_DA1.Depth = 0;
            this.Input_DA1.Hint = "";
            this.Input_DA1.Location = new System.Drawing.Point(500, 254);
            this.Input_DA1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_DA1.Name = "Input_DA1";
            this.Input_DA1.PasswordChar = '\0';
            this.Input_DA1.SelectedText = "";
            this.Input_DA1.SelectionLength = 0;
            this.Input_DA1.SelectionStart = 0;
            this.Input_DA1.Size = new System.Drawing.Size(41, 23);
            this.Input_DA1.TabIndex = 119;
            this.Input_DA1.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(454, 254);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(40, 23);
            this.materialLabel8.TabIndex = 118;
            this.materialLabel8.Text = "DA1";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_DA2
            // 
            this.Input_DA2.Depth = 0;
            this.Input_DA2.Hint = "";
            this.Input_DA2.Location = new System.Drawing.Point(611, 254);
            this.Input_DA2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_DA2.Name = "Input_DA2";
            this.Input_DA2.PasswordChar = '\0';
            this.Input_DA2.SelectedText = "";
            this.Input_DA2.SelectionLength = 0;
            this.Input_DA2.SelectionStart = 0;
            this.Input_DA2.Size = new System.Drawing.Size(41, 23);
            this.Input_DA2.TabIndex = 121;
            this.Input_DA2.UseSystemPasswordChar = false;
            // 
            // materialLabel19
            // 
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(565, 254);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(40, 23);
            this.materialLabel19.TabIndex = 120;
            this.materialLabel19.Text = "DA2";
            this.materialLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_SNA
            // 
            this.Input_SNA.Depth = 0;
            this.Input_SNA.Hint = "";
            this.Input_SNA.Location = new System.Drawing.Point(722, 254);
            this.Input_SNA.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_SNA.Name = "Input_SNA";
            this.Input_SNA.PasswordChar = '\0';
            this.Input_SNA.SelectedText = "";
            this.Input_SNA.SelectionLength = 0;
            this.Input_SNA.SelectionStart = 0;
            this.Input_SNA.Size = new System.Drawing.Size(41, 23);
            this.Input_SNA.TabIndex = 123;
            this.Input_SNA.UseSystemPasswordChar = false;
            // 
            // materialLabel20
            // 
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(676, 254);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(40, 23);
            this.materialLabel20.TabIndex = 122;
            this.materialLabel20.Text = "SNA";
            this.materialLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_SA1
            // 
            this.Input_SA1.Depth = 0;
            this.Input_SA1.Hint = "";
            this.Input_SA1.Location = new System.Drawing.Point(833, 254);
            this.Input_SA1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_SA1.Name = "Input_SA1";
            this.Input_SA1.PasswordChar = '\0';
            this.Input_SA1.SelectedText = "";
            this.Input_SA1.SelectionLength = 0;
            this.Input_SA1.SelectionStart = 0;
            this.Input_SA1.Size = new System.Drawing.Size(41, 23);
            this.Input_SA1.TabIndex = 125;
            this.Input_SA1.UseSystemPasswordChar = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(787, 254);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(40, 23);
            this.materialLabel21.TabIndex = 124;
            this.materialLabel21.Text = "SA1";
            this.materialLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Input_SA2
            // 
            this.Input_SA2.Depth = 0;
            this.Input_SA2.Hint = "";
            this.Input_SA2.Location = new System.Drawing.Point(944, 254);
            this.Input_SA2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input_SA2.Name = "Input_SA2";
            this.Input_SA2.PasswordChar = '\0';
            this.Input_SA2.SelectedText = "";
            this.Input_SA2.SelectionLength = 0;
            this.Input_SA2.SelectionStart = 0;
            this.Input_SA2.Size = new System.Drawing.Size(41, 23);
            this.Input_SA2.TabIndex = 127;
            this.Input_SA2.UseSystemPasswordChar = false;
            // 
            // materialLabel22
            // 
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(898, 254);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(40, 23);
            this.materialLabel22.TabIndex = 126;
            this.materialLabel22.Text = "SA2";
            this.materialLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(661, 82);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(55, 19);
            this.materialLabel9.TabIndex = 128;
            this.materialLabel9.Text = "Theme";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Write_Button
            // 
            this.Write_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Write_Button.Depth = 0;
            this.Write_Button.Location = new System.Drawing.Point(245, 387);
            this.Write_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Write_Button.Name = "Write_Button";
            this.Write_Button.Primary = true;
            this.Write_Button.Size = new System.Drawing.Size(74, 36);
            this.Write_Button.TabIndex = 129;
            this.Write_Button.Text = "WRITE DM";
            this.Write_Button.UseVisualStyleBackColor = true;
            this.Write_Button.Click += new System.EventHandler(this.Write_Button_Click);
            // 
            // Write_DM
            // 
            this.Write_DM.Depth = 0;
            this.Write_DM.Hint = "";
            this.Write_DM.Location = new System.Drawing.Point(56, 395);
            this.Write_DM.MouseState = MaterialSkin.MouseState.HOVER;
            this.Write_DM.Name = "Write_DM";
            this.Write_DM.PasswordChar = '\0';
            this.Write_DM.SelectedText = "";
            this.Write_DM.SelectionLength = 0;
            this.Write_DM.SelectionStart = 0;
            this.Write_DM.Size = new System.Drawing.Size(41, 23);
            this.Write_DM.TabIndex = 131;
            this.Write_DM.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 395);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(32, 19);
            this.materialLabel1.TabIndex = 130;
            this.materialLabel1.Text = "DM";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Write_Value
            // 
            this.Write_Value.Depth = 0;
            this.Write_Value.Hint = "";
            this.Write_Value.Location = new System.Drawing.Point(170, 395);
            this.Write_Value.MouseState = MaterialSkin.MouseState.HOVER;
            this.Write_Value.Name = "Write_Value";
            this.Write_Value.PasswordChar = '\0';
            this.Write_Value.SelectedText = "";
            this.Write_Value.SelectionLength = 0;
            this.Write_Value.SelectionStart = 0;
            this.Write_Value.Size = new System.Drawing.Size(41, 23);
            this.Write_Value.TabIndex = 133;
            this.Write_Value.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(117, 395);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 132;
            this.materialLabel2.Text = "Value";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Read_Num
            // 
            this.Read_Num.Depth = 0;
            this.Read_Num.Hint = "";
            this.Read_Num.Location = new System.Drawing.Point(727, 386);
            this.Read_Num.MouseState = MaterialSkin.MouseState.HOVER;
            this.Read_Num.Name = "Read_Num";
            this.Read_Num.PasswordChar = '\0';
            this.Read_Num.SelectedText = "";
            this.Read_Num.SelectionLength = 0;
            this.Read_Num.SelectionStart = 0;
            this.Read_Num.Size = new System.Drawing.Size(41, 23);
            this.Read_Num.TabIndex = 138;
            this.Read_Num.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(676, 386);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 137;
            this.materialLabel3.Text = "Num.";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Read_DM
            // 
            this.Read_DM.Depth = 0;
            this.Read_DM.Hint = "";
            this.Read_DM.Location = new System.Drawing.Point(611, 386);
            this.Read_DM.MouseState = MaterialSkin.MouseState.HOVER;
            this.Read_DM.Name = "Read_DM";
            this.Read_DM.PasswordChar = '\0';
            this.Read_DM.SelectedText = "";
            this.Read_DM.SelectionLength = 0;
            this.Read_DM.SelectionStart = 0;
            this.Read_DM.Size = new System.Drawing.Size(41, 23);
            this.Read_DM.TabIndex = 136;
            this.Read_DM.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(573, 386);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(32, 19);
            this.materialLabel4.TabIndex = 135;
            this.materialLabel4.Text = "DM";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Read_Button
            // 
            this.Read_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Read_Button.Depth = 0;
            this.Read_Button.Location = new System.Drawing.Point(800, 378);
            this.Read_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Read_Button.Name = "Read_Button";
            this.Read_Button.Primary = true;
            this.Read_Button.Size = new System.Drawing.Size(74, 36);
            this.Read_Button.TabIndex = 134;
            this.Read_Button.Text = "READ DM";
            this.Read_Button.UseVisualStyleBackColor = true;
            this.Read_Button.Click += new System.EventHandler(this.Read_Button_Click);
            // 
            // Read_Result
            // 
            this.Read_Result.Depth = 0;
            this.Read_Result.Font = new System.Drawing.Font("Roboto", 11F);
            this.Read_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Read_Result.Location = new System.Drawing.Point(519, 433);
            this.Read_Result.MouseState = MaterialSkin.MouseState.HOVER;
            this.Read_Result.Name = "Read_Result";
            this.Read_Result.Size = new System.Drawing.Size(419, 97);
            this.Read_Result.TabIndex = 139;
            // 
            // Home1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 552);
            this.Controls.Add(this.Read_Result);
            this.Controls.Add(this.Read_Num);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Read_DM);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.Read_Button);
            this.Controls.Add(this.Write_Value);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Write_DM);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Write_Button);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.Input_SA2);
            this.Controls.Add(this.materialLabel22);
            this.Controls.Add(this.Input_SA1);
            this.Controls.Add(this.materialLabel21);
            this.Controls.Add(this.Input_SNA);
            this.Controls.Add(this.materialLabel20);
            this.Controls.Add(this.Input_DA2);
            this.Controls.Add(this.materialLabel19);
            this.Controls.Add(this.Input_DA1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.Input_DNA);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.Input_GCT);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Input_RSV);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel18);
            this.Controls.Add(this.Input_ICF);
            this.Controls.Add(this.Input_Port_PLC);
            this.Controls.Add(this.Input_IP_PLC);
            this.Controls.Add(this.Input_Port_PC);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.Input_IP_PC);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.PcGetIPButton);
            this.Controls.Add(this.Tema_Light);
            this.Controls.Add(this.Tema_Dark);
            this.Controls.Add(this.PLCPingButton);
            this.Controls.Add(this.Reset_Impostazioni);
            this.Controls.Add(this.Salva_Impostazioni);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Home1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Fins Gateway Omron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton Reset_Impostazioni;
        private MaterialSkin.Controls.MaterialRaisedButton Salva_Impostazioni;
        private MaterialSkin.Controls.MaterialRaisedButton PLCPingButton;
        private MaterialSkin.Controls.MaterialRaisedButton Tema_Dark;
        private MaterialSkin.Controls.MaterialRaisedButton Tema_Light;
        private MaterialSkin.Controls.MaterialRaisedButton PcGetIPButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_IP_PC;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_Port_PC;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_IP_PLC;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_Port_PLC;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_ICF;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_RSV;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_GCT;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_DNA;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_DA1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_DA2;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_SNA;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_SA1;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialSingleLineTextField Input_SA2;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton Write_Button;
        private MaterialSkin.Controls.MaterialSingleLineTextField Write_DM;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Write_Value;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Read_Num;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Read_DM;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton Read_Button;
        private MaterialSkin.Controls.MaterialLabel Read_Result;
    }
}